namespace FluentValidations.Entity;

public class Adress
{
    public string City { get; set; }
    public string Country { get; set; }
    public int ZipCode { get; set; }
    public string? Street { get; set; }
    public string Region { get; set; }
}