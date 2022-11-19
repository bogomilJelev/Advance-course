using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        public List<Ski> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count();

        public SkiRental(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }
        public void Add(Ski ski)
        {
            if (data.Count < Capacity)
            {
                data.Add(ski);
            }
        }
        public bool Remove(string manufacturer,string model)
        {
            Ski curski = data.Where(x => x.Manufacturer == manufacturer).Where(x => x.Model == model).FirstOrDefault();
            if (curski == null)
            {
                return false;
            }
            else
            {
                data.Remove(curski);
                return true;

            }
        }
        public  Ski GetNewestSki()
        {
            Ski curski = data.OrderByDescending(x => x.Year).FirstOrDefault();
            if (!(curski == null))
            {
                return curski;
            }
            return null;

        }
        public Ski GetSki(string manufacturer,string model)
        {
            Ski curski = data.Where(x => x.Manufacturer == manufacturer).Where(x => x.Model == model).FirstOrDefault();
            if (!(curski == null))
            {
                return curski;
            }
            return null;
        }
        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

      
    }
}
