

public class EsStudent: Student
{
  public EsStudent()
  {
    Photography = Random.Shared.Next(2, 7);
    Engineering = Random.Shared.Next(0, 3);
    NetworkDesign = Random.Shared.Next(0, 2);
  }
}