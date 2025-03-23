﻿using System.ComponentModel.DataAnnotations;

namespace Webapp.Models;

public class SignInForm
{
    [Required(ErrorMessage = "Required")]
    [Display(Name = "Email", Prompt = "Enter your email")]
    [DataType(DataType.EmailAddress)]

    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Required")]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]

    public string Password { get; set; } = null!;
}
