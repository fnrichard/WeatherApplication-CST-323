using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApplication.Models
{
    public class WeatherData
    {
        public string Location { get; set; }
        public double Pressure { get; set; }
        public double Tempature { get; set; }
        public double Humidity { get; set; }
        public int Time { get; set; }
        public WeatherData() { }


    }
}
