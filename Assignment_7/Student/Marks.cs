using System;

namespace Student
{
    /// <summary>
    /// Represents a student and assigns grade based on total marks.
    /// </summary>
    public class Marks
    {
        // Student Roll Number
        public int RollNo { get; set; }

        // Student Name
        public string Name { get; set; }

        // Total marks obtained by the student
        public int TotalMarks { get; set; }

        // Grade assigned to the student
        public string Grade { get; set; }

        /// <summary>
        /// Assigns grade to the student based on total marks.
        /// </summary>
        /// <param name="m">Marks object</param>
        public void AssignGrade(Marks m)
        {
            // Grade calculation based on marks
            if (m.TotalMarks >= 75)
            {
                m.Grade = "A";
            }
            else if (m.TotalMarks >= 60)
            {
                m.Grade = "B";
            }
            else
            {
                m.Grade = "C";
            }
        }
    }
}