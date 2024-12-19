using University_management_system;
List<Person> people = new List<Person>
{
    new Student
    {
        Name = "Ali",
        Age = 20,
        StudentId = 12345,
        Major = "Computer Science"
    },
    new Professor
    {
        Name = "Dr. Reza",
        Age = 45,
        ProfessorId = 9876,
        Subject = "Mathematics"
    },
    new Student
    {
        Name = "Sara",
        Age = 22,
        StudentId = 67890,
        Major = "Physics"
    }
};
foreach (var item in people)
{
    Console.WriteLine(item.GetDetails());
}


