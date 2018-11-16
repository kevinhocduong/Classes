/*
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
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }

        public List<double> ExamGrades { get; set; }
        public List<double> FinalExamGrades { get; set; }
        public List<double> HomeworkGrades { get; set; }
        public List<double> ParticipationGrades { get; set; }
        public List<double> QuizGrades { get; set; }

        public Student(int studentID)
        {
            this.StudentID = studentID; 
            ExamGrades = new List<double>();
            FinalExamGrades = new List<double>();
            HomeworkGrades = new List<double>();
            ParticipationGrades = new List<double>();
            QuizGrades = new List<double>();
        }

        public Student(string firstName, string lastName, int studentID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StudentID = studentID;
            ExamGrades = new List<double>();
            FinalExamGrades = new List<double>();
            HomeworkGrades = new List<double>();
            ParticipationGrades = new List<double>();
            QuizGrades = new List<double>();
        }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            StudentID = 0;
            ExamGrades = null;
            FinalExamGrades = null;
            HomeworkGrades = null;
            ParticipationGrades = null;
            QuizGrades = null;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName} ({StudentID})";
        }

        public double CalculateExamAverage()
        {
            int numofExamGrades = ExamGrades.Count;
            double totalofExamGrades = 0;

            foreach (double examgrade in ExamGrades)
            {
                totalofExamGrades += examgrade;
            }

            return totalofExamGrades / numofExamGrades/ 100;
        }

        public double CalculateFinalExamAverage()
        {
            int numofFinalExamGrades = FinalExamGrades.Count;
            double totalofFinalExamGrades = 0;

            foreach (double finalexamgrade in FinalExamGrades)
            {
                totalofFinalExamGrades += finalexamgrade;
            }

            return totalofFinalExamGrades / numofFinalExamGrades / 100;
        }

        public double CalculateHomeworkAverage()
        {
            int numofHomeworkGrades = HomeworkGrades.Count;
            double totalofHomeworkGrades = 0;

            foreach (double homeworkgrade in HomeworkGrades)
            {
                totalofHomeworkGrades += homeworkgrade;
            }

            return totalofHomeworkGrades / numofHomeworkGrades / 100;
        }

        public double CalculateParticipationAverage()
        {
            int numofParticipationGrades = ParticipationGrades.Count;
            double totalofParticipationGrades = 0;

            foreach (double participationgrade in ParticipationGrades)
            {
                totalofParticipationGrades += participationgrade;
            }

            return totalofParticipationGrades / numofParticipationGrades / 100;
        }

        public double CalculateQuizGrade()
        {
            int numofQuizGrades = QuizGrades.Count;
            double totalofQuizGrades = 0;

            foreach (double quizgrade in QuizGrades)
            {
                totalofQuizGrades += quizgrade;
            }

            return totalofQuizGrades / numofQuizGrades / 100;
        }

    }
}
