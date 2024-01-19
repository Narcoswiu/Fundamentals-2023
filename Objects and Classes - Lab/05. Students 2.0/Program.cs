using System.ComponentModel.Design;

string command;
List<Students> students = new List<Students>();
while ((command = Console.ReadLine()) != "end")
{
    string[] studentInfo = command.Split(' ');
    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    string age = studentInfo[2];
    string homeTown = studentInfo[3];

    bool studentExist = false;
    foreach (var student in students)
    {
        if (student.FirstName==firstName&&student.LastName==lastName)
        {
            studentExist = true;
            break;
        }
    }

    if (studentExist)
    {
        foreach (var student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                student.Age=age;
                student.HomeTown=homeTown;
            }
        }
    }
    else
    {
        Students student = new Students
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            HomeTown = homeTown,
        };
        students.Add(student);
    }
    
}


string city = Console.ReadLine();
List<Students> filteredStudents = students.Where(s => s.HomeTown == city).ToList();

foreach (Students student in filteredStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}
class Students
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
    public string HomeTown { get; set; }

}