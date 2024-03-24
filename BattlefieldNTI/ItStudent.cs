

public class ItStudent : Student
{
  public ItStudent()
  {
    Photography = Random.Shared.Next(0, 2);
    Engineering = Random.Shared.Next(0, 3);
    NetworkDesign = Random.Shared.Next(2, 7);
  }
}