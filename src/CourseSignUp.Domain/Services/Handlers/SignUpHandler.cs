using CourseSignUp.Domain.Contracts;
using CourseSignUp.Domain.Contracts.Events;
using CourseSignUp.Domain.Contracts.Repositories;
using CourseSignUp.Domain.Events.Course;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Services.Handlers
{
    public class SignUpHandler : IEventHandler<SignUpEvent>
    {
        private readonly IRespositoryCourseSchedule repSchedule;
        private readonly IRepositoryStudent repStudent;
        private readonly IEventBus eventBus;
        private readonly ILogger logger;

        public SignUpHandler(IRespositoryCourseSchedule repSchedule, IRepositoryStudent repStudent, IEventBus eventBus, ILogger logger)
        {
            this.repSchedule = repSchedule;
            this.repStudent = repStudent;
            this.eventBus = eventBus;
            this.logger = logger;
        }
        public void Handle(SignUpEvent eventItem)
        {
            var schedule = repSchedule.GetByCourseId(eventItem.CourseId, eventItem.Schedule);
            var student = repStudent.GetById(eventItem.StudentId);

            try
            {
                schedule.AddStudent(student);
                eventBus.Publish(new SignUpOkEvent(eventItem.CourseId, eventItem.StudentId));
            }
            catch(Exception ex)
            {
                logger.LogError(ex.Message);
                eventBus.Publish(new SignUpOkEvent(eventItem.CourseId, eventItem.StudentId));
            }
        }
    }
}
