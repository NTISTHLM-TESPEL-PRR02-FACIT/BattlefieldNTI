

public class TeStudent : Student
{
  public TeStudent()
  {
    Photography = Random.Shared.Next(0, 2);
    Engineering = Random.Shared.Next(2, 7);
    NetworkDesign = Random.Shared.Next(0, 3);
  }
}