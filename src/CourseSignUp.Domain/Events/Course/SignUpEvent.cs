using CourseSignUp.Domain.Contracts.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Events.Course
{
    public class SignUpEvent : AEvent
    {
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public DateTime Schedule { get; set; }

        public SignUpEvent(string studentId, string courseId, DateTime schedule)
        {
            this.Id = Guid.NewGuid();
            this.Name = nameof(SignUpEvent);
            this.StudentId = studentId;
            this.CourseId = courseId;
            this.Schedule = schedule;
        }
    }
}
