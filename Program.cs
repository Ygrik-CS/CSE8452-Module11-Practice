using System;

namespace UniversityManagement
{   
    public abstract class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public void Login() => Console.WriteLine($"{FullName} вошел в систему.");
    }

    public class Student : Person
    {
        public string RecordBookNumber { get; set; }
        public List<Course> EnrolledCourses { get; set; } = new();

        public void RegisterOnCourse(Course course) { EnrolledCourses.Add(course); }
        public void ViewGrades() {}
    }

    public class Professor : Person
    {
        public string AcademicDegree { get; set; }
        public List<Course> TeachingCourses { get; set; } = new();

        public void ConductLesson() { }
        public void SubmitGrade(Student student, Exam exam, int value) { }
    }

    public class Admin : Person
    {
        public void ManageStructure() => Console.WriteLine("Изменение структуры университета...");
    }


    public class University
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Faculty> Faculties { get; set; } = new();

        public void AddFaculty(Faculty faculty) => Faculties.Add(faculty);
    }

    public class Faculty
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; } = new();

        public void AddDepartment(Department dept) => Departments.Add(dept);
    }

    public class Department
    {
        public string Name { get; set; }
        public List<Professor> Professors { get; set; } = new();
        public List<Course> Courses { get; set; } = new();

        public void AddProfessor(Professor prof) => Professors.Add(prof);
    }


    public class Course
    {
        public string Title { get; set; }
        public Department Department { get; set; }
        public List<Student> Students { get; set; } = new();
        public List<Schedule> Schedules { get; set; } = new();

        public void AddStudent(Student student) => Students.Add(student);
    }

    public class Schedule
    {
        public DateTime LessonTime { get; set; }
        public string Classroom { get; set; }

        public void ChangeTime(DateTime newTime) { LessonTime = newTime; }
    }

    public class Exam
    {
        public Course Course { get; set; }
        public DateTime Date { get; set; }
        public List<Grade> ExamGrades { get; set; } = new();

        public void AssignDate(DateTime date) { Date = date; }
    }

    public class Grade
    {
        public int Mark { get; set; }
        public Student Student { get; set; }
        public string Comment { get; set; }
    }


    public class Scholarship
    {
        public decimal Amount { get; set; }
        public string Type { get; set; } 

        public void CalculateForStudent(Student student) { }
    }

    public class ScientificProject
    {
        public string Topic { get; set; }
        public Professor Lead { get; set; }
        public List<Student> Participants { get; set; } = new();
    }
}
