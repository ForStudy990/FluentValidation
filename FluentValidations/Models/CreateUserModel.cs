using FluentValidations.Entity;

namespace FluentValidations.Models;

public class CreateUserModel
{
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; }
    public byte[]? Age { get; set; }
    public Adress? UserAdress { get; set; }
}