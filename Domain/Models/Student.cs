using Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Student : Entity
    {

        protected Student() { }

        public Student(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public Address Address { get; set; }
    }
}
