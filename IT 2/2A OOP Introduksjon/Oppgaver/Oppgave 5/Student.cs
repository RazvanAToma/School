using System;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StudentId { get; set; }
    public string StudyProgram { get; set; }

    public Student(string firstName, string lastName, string studentId, string studyProgram)
    {
        FirstName = firstName;
        LastName = lastName;
        StudentId = studentId;
        StudyProgram = studyProgram;
    }

    public string PrintInfo()
    {
        return $"{LastName}, {FirstName}\n{StudentId}, {StudyProgram}";
    }
}
