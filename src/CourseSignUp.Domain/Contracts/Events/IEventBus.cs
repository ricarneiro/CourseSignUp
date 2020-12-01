using CourseSignUp.Domain.Contracts.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Contracts
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent eventItem) where TEvent : AEvent;
        void Subscribe<TEvent, TEventHandler>();
    }
}
