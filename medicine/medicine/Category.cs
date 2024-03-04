using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicine
{
    public class Category
    {
        public string Name { get; set; }
        public List<Drug> Drugs { get; set; }

        public Category(string name)
        {
            Name = name;
            Drugs = new List<Drug>();
        }
    }
}
