using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Entities
{
    public class CourseSchedule : AEntity
    {
        public DateTime DhScheduled { get; set; }
        public CourseLecture Course { get; set; }
        public List<Student> Students { get; private set; }

        public void AddStudent(Student student)
        {
            if (this.Students.Count > this.Course.NumberOfStudents) throw new Exception($"This course has {this.Course.NumberOfStudents} limit.");
            this.Students.Add(student);
        }
    }
}
