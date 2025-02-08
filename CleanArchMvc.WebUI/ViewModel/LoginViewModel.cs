﻿using System.ComponentModel.DataAnnotations;

namespace CleanArchMvc.WebUI.ViewModel;

public class LoginViewModel
{
    [Required(ErrorMessage = "The Email field is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "The Password field is required.")]
    [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}
