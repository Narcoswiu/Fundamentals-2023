using System.Diagnostics.CodeAnalysis;
int studentsCount = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
for (int i = 0; i < studentsCount; i++)
{
    string studentName = Console.ReadLine();
    decimal grade = decimal.Parse(Console.ReadLine());
    
    if (!students.ContainsKey(studentName))
    {
        students.Add(studentName,new List<decimal>());
    }

    students[studentName].Add(grade); ;
}

var filteredStudents = students.Where(pair => pair.Value.Average() >= 4.50m);
foreach (var studentPair in filteredStudents)
{
    Console.WriteLine($"{studentPair.Key} -> {studentPair.Value.Average():F2}");
}
