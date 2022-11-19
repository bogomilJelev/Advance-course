using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    class Clinic
    {
        private List<Pet> date;
        public int Count 
        {
            get { return date.Count;     }
        }
        public Clinic(int capacity)
        {
            Capacity = capacity;
            date = new List<Pet>();
        }
        public int Capacity { get; set; }

        public void Add(Pet pet)
        {
            if (date.Count < Capacity)
            {
            date.Add(pet);
            }
        }
        public bool Remove (string name)
        {
            Pet pet = date.FirstOrDefault(p => p.Name == name);

                if (pet == null)
                {
                    return false;
                }
                date.Remove(pet);

            return true;
            

        }
        public Pet GetPet(string name,string owner)
        {
            Pet pet = date.FirstOrDefault(p => p.Name == name && p.Owner == owner);
            return pet;
        }
        public Pet GetOldestPet()
        {
            Pet pet = date.OrderByDescending(p => p.Age).FirstOrDefault();
             return pet;
        }
        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"The clinic has the following patients:");
            foreach (var item in date)
            {
                result.Append($"Pet {item.Name} with owner: {item.Owner}");
            }
            return result.ToString();

           
        } 
    }
}
