﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Business.Models;

public class AddClientForm
{
    [Display(Name = "Client Image", Prompt = "Select a image")]
    [DataType(DataType.Upload)]

    public IFormFile? ClientImage { get; set; }


    [Display(Name = "Client Name", Prompt = "Enter client name")]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Required")]

    public string ClientName { get; set; } = null!;


    [Display(Name = "Email", Prompt = "Enter email address")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Required")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email")]

    public string Email { get; set; } = null!;


    [Display(Name = "Location", Prompt = "Enter location")]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Required")]

    public string? Location { get; set; }

    [Display(Name = "Phone", Prompt = "Enter phone number")]
    [DataType(DataType.PhoneNumber)]

    public string? Phone { get; set; }
}
