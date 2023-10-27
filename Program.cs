
public class Student
{
    public string Name { get; set; }
    public string ClassAndSection { get; set; }

    public Student(string name, string classAndSection)
    {
        Name = name;
        ClassAndSection = classAndSection;
    }
}

public class Teacher
{
    public string Name { get; set; }
    public string ClassAndSection { get; set; }

    public Teacher(string name, string classAndSection)
    {
        Name = name;
        ClassAndSection = classAndSection;
    }
}

public class Subject
{
    public string Name { get; set; }
    public string SubjectCode { get; set; }
    public Teacher Teacher { get; set; }

    public Subject(string name, string subjectCode, Teacher teacher)
    {
        Name = name;
        SubjectCode = subjectCode;
        Teacher = teacher;
    }
}