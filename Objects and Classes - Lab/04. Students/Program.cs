string command;
List<Students> students = new List<Students>();
while ((command = Console.ReadLine()) != "end")
{
    string[] studentInfo = command.Split(' ');
    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    string age = studentInfo[2];
    string homeTown = studentInfo[3];
    Students student = new Students
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        HomeTown = homeTown,
    };
    students.Add(student);
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