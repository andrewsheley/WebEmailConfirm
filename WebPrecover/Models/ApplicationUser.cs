﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPrecover.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public DateTime DateOfBirth { get; set; }
    }
}
