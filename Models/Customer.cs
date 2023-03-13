namespace NHibernateDotNet.Models;
public class Customer
{
    public virtual int Id { get; set; }
    public virtual string FirstName { get; set; } = null!;
    public virtual string LastName { get; set; } = null!;
}

