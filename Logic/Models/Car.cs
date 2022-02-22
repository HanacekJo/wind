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
        #region NewWayFullProp
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        #endregion

        // Method
        internal void Horn()
        {
            Console.WriteLine(" Car is horning");
        }
    }
}
