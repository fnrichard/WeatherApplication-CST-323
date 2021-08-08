using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApplication.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        [DisplayName("Username")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string password { get; set; }



    }
}
