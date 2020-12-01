using CourseSignUp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Contracts.Repositories
{
    public interface IRespositoryCourseSchedule
    {
        void Save(CourseSchedule schedule);
        CourseSchedule GetByCourseId(string courseId, DateTime schedule);
    }
}
