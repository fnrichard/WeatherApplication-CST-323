using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApplication.Models;

namespace WeatherApplication
{
    public interface IDataDAO
    {
        public List<WeatherData> getAllData();
        public WeatherData getCurrentData();
        public List<string> getAllLocations();
        public WeatherData getDataByLocation(string location);
    }
}
