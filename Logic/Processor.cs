using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Processor
    {
        public void Run()
        {
            //PeopleProcess();
            
            
            Car mirekCar = new Car();
            mirekCar.SetMark("Peugeot");
            Console.WriteLine("Mirek has car with mark:" + mirekCar.GetMark());
           
            
           
            Console.ReadLine();






        }

        private void PeopleProcess()
        {
            Person mirek = new Person();
            mirek.FirstName = "Miroslav";
            mirek.LastName = "Vaculka";
            mirek.Age = 30;
            mirek.Height = 183.0;
            mirek.Weight = 78.5m;

            Person sabina = new Person();
            sabina.FirstName = "Sabina";

            List<Person> people = new List<Person>();
            people.Add(mirek);
            people.Add(sabina);

            Console.WriteLine("Máme tu tyto lidi: ");

            foreach (Person person in people) //for each person in people, cyklus foreach si vytvoří 

                sabina.Walk();
        }
    }
}
