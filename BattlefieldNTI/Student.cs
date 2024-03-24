public class Student
{
  public string Name;
  public int Photography;
  public int Engineering;
  public int NetworkDesign;

  public string GetGrade(int competence)
  {
    int result = Random.Shared.Next(competence);
    if (result == 0)
    {
      return "F";
    }
    else if (result == 1)
    {
      return "E";
    }
    else if (result == 2)
    {
      return "C";
    }
    else
    {
      return "A";
    }
  }

  public string GetPhotoGrade()
  {
    return GetGrade(Photography);
  }

  public string GetEngineerGrade()
  {
    return GetGrade(Engineering);
  }

  public string GetNetworkGrade()
  {
    return GetGrade(NetworkDesign);
  }
}