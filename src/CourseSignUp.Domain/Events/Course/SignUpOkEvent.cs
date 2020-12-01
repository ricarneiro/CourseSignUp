using CourseSignUp.Domain.Contracts.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Events.Course
{
    public class SignUpOkEvent : AEvent
    {
        public string CourseId { get; set; }
        public string StudentId { get; set; }

        public SignUpOkEvent(string courseId, string studentId)
        {
            this.Id = Guid.NewGuid();
            this.Name = nameof(SignUpEvent);
            this.CourseId = courseId;
            this.StudentId = studentId;
        }
    }
}
