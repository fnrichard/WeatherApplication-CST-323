using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApplication.Models;

namespace WeatherApplication.Controllers
{
    public class WeatherController : Controller
    {
        public IDataDAO weatherData;

        public WeatherController(IDataDAO dataServices)
        {
            weatherData = dataServices;
        }


        public IActionResult Index()
        {
            return View("LocationsHome", weatherData.getAllData());
        }


        public IActionResult OpenWeather(string location)
        {
            System.Diagnostics.Debug.WriteLine("test: " + location);
            return View("DisplayWeather", weatherData.getDataByLocation(location));
        }

    }
}
