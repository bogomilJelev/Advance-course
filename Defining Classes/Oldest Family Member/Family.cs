﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }
        
        public List<Person> Members { get; set; }

        public void AddMember(Person name)
        {
            
            this.Members.Add(name);
        }
        public Person GetOldestMember()
        {
            Person person = this.Members.OrderByDescending(p => p.Age).First();
            return person;
            
        }

    }
}
