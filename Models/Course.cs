namespace Registrar.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; } = "";
        public string Title { get; set; } = "";
        public int WeeklyHours { get; set; }
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}
