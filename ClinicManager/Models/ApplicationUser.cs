﻿using Microsoft.AspNetCore.Identity;

namespace ClinicManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
    }
}
