﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Business.Models;

public class AddMemberForm
{
    [Display(Name = "Member Image", Prompt = "Select a image")]
    [DataType(DataType.Upload)]

    public IFormFile? MemberImage { get; set; }


    [Display(Name = "Member Name", Prompt = "Enter member name")]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Required")]

    public string MemberName { get; set; } = null!;


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
