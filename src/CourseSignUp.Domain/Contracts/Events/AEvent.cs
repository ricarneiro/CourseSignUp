using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Contracts.Events
{
    public abstract class AEvent
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string JsonData { get; protected set; }
        public Type JsonType { get; protected set; }
    }
}
