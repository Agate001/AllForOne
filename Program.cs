var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
