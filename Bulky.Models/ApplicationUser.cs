﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        //public string PhoneNumber { get; set; }
        //public string? CompanyName { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        //public string? ProfilePictureUrl { get; set; }
        //public bool IsAdmin { get; set; } = false;
    }
}
