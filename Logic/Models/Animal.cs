using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    internal class Animal
    {
        private int _numberOfLegs;
        private string _name;
        /// <summary>
        /// "Constructor"
        /// </summary>
        /// <param name="numberOfLegs">Počet nohou </param>
        public Animal(int numberOfLegs) // ctor - zkratka pro tvorbu konstruktoru
        {
            _numberOfLegs = numberOfLegs;
        }
        public Animal(int numberOfLegs, string name)
            :this(numberOfLegs) // volá jiný kontruktor, který již má přiřazený počet nohou - stejný argument
        {
            _name = name;
        }

        public int NumberOfLegs
        {
            get { return _numberOfLegs; }
        }
        

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
