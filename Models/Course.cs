namespace Registrar;

public class Course
{
  public string Code { get; set; } = "";
  public string Title { get; set; } = "";
  public int WeeklyHours { get; set; }
  public bool IsEnrolled { get; set; } = false;
  public bool IsSelected { get; set; }

	public override string ToString()
  {
      return Code + " " + Title + " " + WeeklyHours.ToString() + (WeeklyHours==1 ? "hour":" hours") + " per week";
  }
}



