using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Contracts.Events
{
    public interface IEventHandler<TEvent>
    {
        void Handle(TEvent eventItem);
    }
}
