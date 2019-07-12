using Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Events
{
    public class StudentRegisteredEvent : Event
    {
        public StudentRegisteredEvent(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            AggregateId = id;
        }
        public Guid Id { get; set; }

        public string Name { get; private set; }

        public string Email { get; private set; }
    }
}
