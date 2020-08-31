using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuthentication.ViewModels
{
    public class MyIdentityUser : IdentityUser
    {
       
        [Required]
        public string UserLastName { get; set; }

        [Required]
        public string UserFirstName { get; set; }

        [Required]
        public double UserWeight { get; set; }

        [Required]
        public double UserHeight { get; set; }

        [Required]
        public string DeviceID { get; set; }

    }
}
