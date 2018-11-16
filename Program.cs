// Kevin Hoc Duong

/*
 * Create a new solution and project, name both of them Homework7Classes. 
 * You will be creating a student class using the UML below. 
 * In your Program.cs in the Main method, make 3 instances (objects) of the Student class and populate them with data. 
 * Once you have populated them with data (including grades), output the student with all of the averages for their grades.
 * 
 * Student
 * 
 * FirstName : string
 * LastName : string
 * StudentId : int
 * ExamGrades : List<double>
 * FinalExamGrades : List<double>
 * HomeworkGrades : List<double>
 * ParticipationGrades : List<double>
 * QuizGrades : List<double>
 * 
 * Student ( )
 * 
 * Student ( int studentId )
 * Student ( string firstName, string lastName, int studentId )
 * ToString ( ) : string
 * CalculateExamAverage ( ) : double
 * CalculateFinalExamAverage ( ) : double
 * CalculateHomeworkAverage ( ) : double
 * CalculateParticipationAverage ( ) : double
 * CalculateQuizAverage ( ) : double
 * 
 * ToString( ) - Returns a string representation of the instance of the class.  The format of the string should be: LastName, FirstName (StudentId)
 * CalculateExamAverage ( ) - Returns a double that is the average of the exam grades for the student.
 * CalculateFinalExamAverage ( ) - Returns a double that is the average of the final exam grades for the student.
 * CalculateHomeworkAverage ( ) - Returns a double that is the average of the homework grades for the student.
 * CalculateParticipationAverage ( ) - Returns a double that is the average of the participation grades for the student.
 * CalculateQuizAverage ( ) - Returns a double that is the average of the quiz grades for the student. 
 */

using System;
using System.Collections.Generic;

namespace Homework7Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.FirstName = "Kevin";
            myStudent.LastName = "Duong";
            myStudent.StudentID = 113101550;

            myStudent.ExamGrades = new List<double>();
            myStudent.ExamGrades.Add(88);
            myStudent.ExamGrades.Add(96);
            myStudent.ExamGrades.Add(90);

            myStudent.FinalExamGrades = new List<double>();
            myStudent.FinalExamGrades.Add(90);

            myStudent.HomeworkGrades = new List<double>();
            myStudent.HomeworkGrades.Add(100);
            myStudent.HomeworkGrades.Add(95);
            myStudent.HomeworkGrades.Add(97);

            myStudent.ParticipationGrades = new List<double>();
            myStudent.ParticipationGrades.Add(100);
            myStudent.ParticipationGrades.Add(80);
            myStudent.ParticipationGrades.Add(100);

            myStudent.QuizGrades = new List<double>();
            myStudent.QuizGrades.Add(70);
            myStudent.QuizGrades.Add(90);
            myStudent.QuizGrades.Add(95);

            Console.WriteLine(myStudent.ToString().ToUpper());
            Console.WriteLine($"Exam Average: {myStudent.CalculateExamAverage().ToString("P2")}");
            Console.WriteLine($"Final Exam Average: {myStudent.CalculateFinalExamAverage().ToString("P2")}");
            Console.WriteLine($"Homework Average: {myStudent.CalculateHomeworkAverage().ToString("P2")}");
            Console.WriteLine($"Participation Average: {myStudent.CalculateParticipationAverage().ToString("P2")}");
            Console.WriteLine($"Quiz Average: {myStudent.CalculateQuizGrade().ToString("P2")}");

            Student theStudent = new Student();
            theStudent.FirstName = "Jonathon";
            theStudent.LastName = "Cline";
            theStudent.StudentID = 113346656;

            theStudent.ExamGrades = new List<double>();
            theStudent.ExamGrades.Add(90);
            theStudent.ExamGrades.Add(65);
            theStudent.ExamGrades.Add(82);

            theStudent.FinalExamGrades = new List<double>();
            theStudent.FinalExamGrades.Add(86);

            theStudent.HomeworkGrades = new List<double>();
            theStudent.HomeworkGrades.Add(84);
            theStudent.HomeworkGrades.Add(91);
            theStudent.HomeworkGrades.Add(97);

            theStudent.ParticipationGrades = new List<double>();
            theStudent.ParticipationGrades.Add(100);
            theStudent.ParticipationGrades.Add(100);
            theStudent.ParticipationGrades.Add(100);

            theStudent.QuizGrades = new List<double>();
            theStudent.QuizGrades.Add(60);
            theStudent.QuizGrades.Add(83);
            theStudent.QuizGrades.Add(78);
            theStudent.QuizGrades.Add(91);

            Console.WriteLine();
            Console.WriteLine(theStudent.ToString().ToUpper());
            Console.WriteLine($"Exam Average: {theStudent.CalculateExamAverage().ToString("P2")}");
            Console.WriteLine($"Final Exam Average: {theStudent.CalculateFinalExamAverage().ToString("P2")}");
            Console.WriteLine($"Homework Average: {theStudent.CalculateHomeworkAverage().ToString("P2")}");
            Console.WriteLine($"Participation Average: {theStudent.CalculateParticipationAverage().ToString("P2")}");
            Console.WriteLine($"Quiz Average: {theStudent.CalculateQuizGrade().ToString("P2")}");

            Student aStudent = new Student();
            aStudent.FirstName = "Parker";
            aStudent.LastName = "Austin";
            aStudent.StudentID = 113768501;

            aStudent.ExamGrades = new List<double>();
            aStudent.ExamGrades.Add(65);
            aStudent.ExamGrades.Add(78);
            aStudent.ExamGrades.Add(83);

            aStudent.FinalExamGrades = new List<double>();
            aStudent.FinalExamGrades.Add(81);

            aStudent.HomeworkGrades = new List<double>();
            aStudent.HomeworkGrades.Add(100);
            aStudent.HomeworkGrades.Add(93);
            aStudent.HomeworkGrades.Add(97);

            aStudent.ParticipationGrades = new List<double>();
            aStudent.ParticipationGrades.Add(100);
            aStudent.ParticipationGrades.Add(100);
            aStudent.ParticipationGrades.Add(100);

            aStudent.QuizGrades = new List<double>();
            aStudent.QuizGrades.Add(90);
            aStudent.QuizGrades.Add(84);
            aStudent.QuizGrades.Add(87);

            Console.WriteLine();
            Console.WriteLine(aStudent.ToString().ToUpper());
            Console.WriteLine($"Exam Average: {aStudent.CalculateExamAverage().ToString("P2")}");
            Console.WriteLine($"Final Exam Average: {aStudent.CalculateFinalExamAverage().ToString("P2")}");
            Console.WriteLine($"Homework Average: {aStudent.CalculateHomeworkAverage().ToString("P2")}");
            Console.WriteLine($"Participation Average: {aStudent.CalculateParticipationAverage().ToString("P2")}");
            Console.WriteLine($"Quiz Average: {aStudent.CalculateQuizGrade().ToString("P2")}");


            Console.ReadKey();
        }
    }
}
