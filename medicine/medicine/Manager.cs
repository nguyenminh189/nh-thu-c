using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicine
{
    public class Manager
    {
        public List<Category> Categories { get; set; }

        public Manager()
        {
            Categories = new List<Category>();
        }

        public void AddDrug(string categoryName, Drug drug)
        {
            var category = Categories.Find(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));
            if (category != null)
            {
                category.Drugs.Add(drug);
                Console.WriteLine("Added: " + categoryName);
            }
            else
            {
                Console.WriteLine("Not found: " + categoryName);
            }
        }

        public void DisplayDrugsByCategory(string categoryName)
        {
            var category = Categories.Find(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));
            if (category != null)
            {
                Console.WriteLine($"Category '{categoryName}':");
                foreach (var drug in category.Drugs)
                {
                    Console.WriteLine($"Name: {drug.Name}, Quantity: {drug.Quantity}, Price: {drug.Price}");
                }
            }
            else
            {
                Console.WriteLine("Not found: " + categoryName);
            }
        }

        public void DisplayDrugDetails(string drugName)
        {
            foreach (var category in Categories)
            {
                var drug = category.Drugs.Find(d => d.Name.Equals(drugName, StringComparison.OrdinalIgnoreCase));
                if (drug != null)
                {
                    Console.WriteLine($"Details '{drugName}':");
                    Console.WriteLine($"Name: {drug.Name}, Quantity: {drug.Quantity}, Price: {drug.Price}");
                    return;
                }
            }
            Console.WriteLine("Not found: " + drugName);
        }
    }
}
