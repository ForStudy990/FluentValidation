using FluentValidations.Models;
using FluentValidations.Validation;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidations.Controllers;
[Route("/api/[controller]")]
[ApiController]
public class UserController() : Controller
{
    
    [HttpPost("Register")]
    public IActionResult Register(CreateUserModel model)
    {
        var validator = new RegisterValidator();
        var result = validator.Validate(model);
        if(!result.IsValid)
            return BadRequest(result.Errors);
        return Ok("Registration Successful");
    }
}