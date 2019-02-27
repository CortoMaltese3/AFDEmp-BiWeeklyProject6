using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiWeeklyProject6_V4.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]          
        public string Password { get; set; }

        [Required]
        [Display(Name = "Role")]
        public UserRoles UserRole {get;set;}        
    }

    public enum UserRoles
    {
        Architect,
        Analyst,        
        Programmer, 
        Tester,
        Manager
    }
}