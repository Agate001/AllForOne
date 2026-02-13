var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddScoped<AllForOne.services.SayHello>();
builder.Services.AddScoped<AllForOne.services.LibMaker>();
builder.Services.AddScoped<AllForOne.services.Magic8bakk>();
builder.Services.AddScoped<AllForOne.services.OddEven>();
builder.Services.AddScoped<AllForOne.services.Questions>();
builder.Services.AddScoped<AllForOne.services.Addition>();
builder.Services.AddScoped<AllForOne.services.RestrauntPicker>();
builder.Services.AddScoped<AllForOne.services.StringReverse>();
builder.Services.AddScoped<AllForOne.services.NumberReverse>();
builder.Services.AddScoped<AllForOne.services.GuessIt>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll"); 

app.UseAuthorization();

app.MapControllers();

app.Run();
