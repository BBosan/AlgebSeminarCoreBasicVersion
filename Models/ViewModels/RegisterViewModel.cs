using Microsoft.AspNetCore.Mvc;
using SeminarCore2.Controllers;
using SeminarCore2.Extra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(action: nameof(AccountController.IsEmailInUse), controller: "Account")]
        [ValidEmailDomain(allowedDomain: "admin.com", ErrorMessage = "Domain Not Allowed")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }

        public string Grad { get; set; }

    }
}
