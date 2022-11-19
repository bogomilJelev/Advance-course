using System;
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
        public void GetOldestMember()
        {

            foreach (var item in Members.OrderByDescending(p=>p.Age>30).ThenBy(p=>p.Name))
            {
                if (item.Age > 30)
                {
                Console.WriteLine($"{item.Name} - {item.Age}");

                }
            }
        }

    }
}
