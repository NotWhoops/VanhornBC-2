using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanhornBMC6.Services;

namespace VanhornBMC6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;

            public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
            {
                _restaurantPickerServices = restaurantPickerServices;
            }
            [HttpGet]
            [Route("RestaurantPickerServices/{userInput}")]
            public string Magic8BallServices(string userInput)
            {
                return _restaurantPickerServices.
                RestaurantPicker(userInput);
            }
    }
}