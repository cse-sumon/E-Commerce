using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OA.Data
{
    public class ApplicationUser : IdentityUser

    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
