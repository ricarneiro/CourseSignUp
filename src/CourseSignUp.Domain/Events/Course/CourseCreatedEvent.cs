using CourseSignUp.Domain.Contracts.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Events.Course
{
    public class CourseCreatedEvent : AEvent
    {
        public string CourseId { get; set; }
        public int NumberOfStudents { get; set; }
        public CourseCreatedEvent(string courseId, int numberOfStudents)
        {
            this.Id = Guid.NewGuid();
            this.Name = nameof(SignUpEvent);
            this.CourseId = courseId;
            this.NumberOfStudents = numberOfStudents;
        }
    }
}
