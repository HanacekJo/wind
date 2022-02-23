using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    internal class Car
    {
        #region Oldway 
        //Field
        private string _mark;

        internal void SetMark(string mark)
        {
            _mark = mark;
        }
        internal string GetMark()
        {
            return _mark;
        }
        #endregion
        #region NewWayFullProp   // plná cesta
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        #endregion
        private int _numberOfHorns=0;

        public int NumberOfHorns
        {
            get { return _numberOfHorns; }
            set { _numberOfHorns = value; }
        }

        // Method
        /// zatroubí jednou
        internal void Horn()
        {
            _numberOfHorns++;
            Console.WriteLine(" Car is horning");
        }
        // Overloaded method, - jmenuje se stejně, ale má jiné argumenty. Program sám zjistí, kterou metodu voláme podle argumentů
        /// <summary>
        /// zatroubí kolikrát chceš
        /// </summary>
        /// <param name="numberOfHorns">počet zatroubení</param>
        internal void Horn(int numberOfHorns)
        {
            _numberOfHorns += numberOfHorns;
            for (int i = 0; i < numberOfHorns; i++)
            {
                Console.WriteLine(" Car is horning"); 
            }
        }

        private string? _color;

        public string? Color
        {
            get { return _color; }
            set {
                _color = value;
                Console.WriteLine("Car color was set: "+ _color);
                }
        }



    }
}
