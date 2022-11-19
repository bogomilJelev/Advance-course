using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
     public class Box<T>
    {
        private List<T> data;
        public int Count => data.Count;
        public Box()
        {
            data = new List<T>();
        }
        public void Add(T item)
        {
            data.Add(item);
        }
        public T Remove()
        {
            T ask = data.LastOrDefault();
            data.Remove(ask);
            return ask;
            
        }
    }
}
