using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebApplication8.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage = "Name is required")] public string firstName { get; set; }
        [Required(ErrorMessage = "LastName is required")] public string lasttName { get; set; }
        public string day { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string gender { get; set; }

        [Required(ErrorMessage = "Email is required")] public string email { get; set; }

        [Required(ErrorMessage = "Password is required")] public string password { get; set; }

        public string confirm { get; set; }
    }
}
