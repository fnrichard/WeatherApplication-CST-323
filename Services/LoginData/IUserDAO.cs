using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApplication.Services.LoginData
{
    public interface IUserDAO
    {
        public bool login(string username, string password);
        public bool registerNewUser(string Email, string username, string password);

    }
}
