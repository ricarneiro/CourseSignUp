using CourseSignUp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Contracts.Repositories
{
    public interface IRepositoryStudent
    {
        Student GetById(string id);
    }
}
