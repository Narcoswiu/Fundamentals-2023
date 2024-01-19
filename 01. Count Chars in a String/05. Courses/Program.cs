Dictionary<string, Course> courses = new Dictionary<string, Course>();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] arguments = input.Split(" : ");
    string courseName = arguments[0];
    string studentName = arguments[1];
    if (!courses.ContainsKey(courseName))
    {
        Course course = new Course(courseName);
        courses.Add(course.Name, course);
    }
    courses[courseName].studentNames.Add(studentName);
}

foreach (var coursesPair in courses)
{
    Console.WriteLine(coursesPair.Value);
}

class Course
{
    public string Name;

    public List<string> studentNames;

    public Course(string name)
    {
        Name = name;
        studentNames = new List<string>();
    }

    public override string ToString()
    {
        string result = $"{Name}: {studentNames.Count}\n";
        for (int i = 0; i < studentNames.Count; i++)
        {
            result += $"-- {studentNames[i]}\n";
        }

        return result.Trim();
    }
}