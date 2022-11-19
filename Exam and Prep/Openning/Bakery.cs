using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    class Bakery
    {
        private List<Employee> data;
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();

        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;


        public void Add(Employee employee)
        {
            if (Capacity > data.Count)
            {
                data.Add(employee);
            }
        }
        public bool Remove(string name)
        {
            Employee cur = data.FirstOrDefault(x => x.Name == name);
            if (cur == null)
            {
                return false;

            }
            else
            {
                return data.Remove(cur);
            }

        }
        public Employee GetOldestEmployee()
        {
            return data.OrderByDescending(x => x.Age).First();
        }
        public Employee GetEmployee(string name)
        {
            Employee cur = data.FirstOrDefault(x => x.Name == name);
            return cur;
        }
        public string Report()
        {
            StringBuilder curstring = new StringBuilder();
            curstring.AppendLine($"Employees working at Bakery {Name}:");
            foreach (var item in data)
            {
                curstring.AppendLine(item.Name);
            }
            return curstring.ToString();

        }

    }
}
