namespace Registrar.Models
{
public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Type { get; set; }
    public ICollection<Registration>? Registrations { get; set; }
}

}
