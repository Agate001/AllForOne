using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestrauntPick : ControllerBase
    {
        private readonly RestrauntPicker _restrauntPickerService;
        public RestrauntPick(RestrauntPicker restrauntPickerService)
        {
            _restrauntPickerService = restrauntPickerService;
        }
        [HttpGet("get/{category}")]
        public string PickRestraunt(string category)
        {
            return _restrauntPickerService.RestaurantSuggestion(category);
        }
    }
}