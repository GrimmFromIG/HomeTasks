using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }

    public Student(string firstName, string lastName, string middleName)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }
    
    public override string ToString()
    {
        return $"{FirstName} {MiddleName} {LastName}";
    }
}

class StudentTable
{
    private List<Student> students = new List<Student>();

    public Student this[int index]
    {
        get { return students[index]; }
        set { students[index] = value; }
    }

    public int StudentCount
    {
        get { return students.Count; }
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    
    public void UpdateStudent(int index, string firstName, string lastName, string middleName)
    {
        if (index >= 0 && index < students.Count)
        {
            students[index].FirstName = firstName;
            students[index].LastName = lastName;
            students[index].MiddleName = middleName;
        }
        else
        {
            Console.WriteLine("Помилка: неправильний індекс студента.");
        }
    }
}