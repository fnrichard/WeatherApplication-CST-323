using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApplication.Models;
using WeatherApplication.Services.LoginData;

namespace WeatherApplication.Controllers
{
    public class LoginController : Controller
    {
        public IUserDAO ss { get; set; }

        public LoginController(IUserDAO data)
        {
            ss = data;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
           
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ProcessLogin(string username, string password)
        {
            string outcome = "LoginSuccess";
            if (!ss.login(username, password))
                outcome = "Login";

            return View(outcome);
        }

        public IActionResult ProcessRegister(string email, string username, string password)
        {
            if (!ss.registerNewUser(email, username, password))
                return View("Register");

            return View("Login");
        }


    }
}
