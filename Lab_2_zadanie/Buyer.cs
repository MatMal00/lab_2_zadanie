using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_zadanie
{
    internal class Buyer: Person
    {
        protected List<Product> tasks = new();

        public Buyer(string name, int age): base(name, age)
        {
            tasks = new List<Product>(); 
        }

        public void AddProduct(Product product)
        {
            if (product == null) return;
            tasks.Add(product); 
        }

        public void RemoveProduct(int index)
        {
            if(index > this.tasks.Count - 1 || index < 0) return;

            tasks.RemoveAt(index);
        }

        public void Print(string prefix = "\t")
        {
        }
    }
}
