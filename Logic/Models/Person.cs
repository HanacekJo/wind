using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// Věk
        /// </summary>
        public int Age { get; set; }
        public double Height { get; set; }
        public decimal? Weight { get; set; }

        public void Walk()
        {
            Console.WriteLine(FirstName + " is walking ...");
        }
        
    }
}
