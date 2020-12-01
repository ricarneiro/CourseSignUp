using CourseSignUp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Contracts.Repositories
{
    public interface IRepositoryCourse
    {
        void Save(CourseLecture course);
        CourseLecture GetById(int id);
    }
}
