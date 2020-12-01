using CourseSignUp.Api.Courses;
using CourseSignUp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Contracts.Services
{
    public interface ICourseService
    {
        CourseLecture Get(string courseId);
        void Create(CreateCourseDto course);
        void Signup(SignUpToCourseDto courseSignUp);
    }
}
