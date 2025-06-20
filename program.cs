using System;

class Program
{
    static void Main(string[] args)
    {
        // Create and initialize Student object
        Student student = new Student();
        student.Name = "Khushbu";
        student.Age = 20;
        student.Course = ".NET Programming";

        // Use methods from both parts of the partial class
        student.DisplayBasicInfo();
        student.DisplayCourse();
    }
}
