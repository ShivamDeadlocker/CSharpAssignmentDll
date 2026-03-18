using System;

namespace Student
{
    /// <summary>
    /// Represents a student with basic details like name, roll number and grade.
    /// </summary>
    public class Student
    {
        // Student name
        public string name { get; set; }

        // Student roll number
        public int rollNumber { get; set; }

        // Student grade
        public string grade { get; set; }

        /// <summary>
        /// Creates and returns a Student object with given details.
        /// </summary>
        /// <param name="name">Student name</param>
        /// <param name="rollNumber">Student roll number</param>
        /// <param name="grade">Student grade</param>
        /// <returns>Student object</returns>
        public static Student CreateStudent(string name, int rollNumber, string grade)
        {
            // Create student object
            Student s = new Student();

            // Assign values
            s.name = name;
            s.rollNumber = rollNumber;
            s.grade = grade;

            // Return created student object
            return s;
        }
    }
}