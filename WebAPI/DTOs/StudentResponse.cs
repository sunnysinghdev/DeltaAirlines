using System.Collections.Generic;

public class StudentResponse
{
    public int Id { get; set; }
    public List<Student> Students { get; set; }
}
public class Student
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public List<string> Hobbies { get; set; }
}