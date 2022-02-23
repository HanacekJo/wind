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
            //CarProcess();
            Animal animal = new Animal(4);

            Console.WriteLine(animal.NumberOfLegs);

            Animal papousek = new Animal(2, "Žoli");

          
        }

        private void CarProcess()
        {
            Car mirekCar = new Car();
            mirekCar.SetMark("Peugeot");
            Console.WriteLine("Mirek has car with mark:" + mirekCar.GetMark());
            mirekCar.Color = "blue";
            mirekCar.Horn();
            mirekCar.Horn();
            mirekCar.Horn(10);
            Console.WriteLine($"Mirek horned {mirekCar.NumberOfHorns} times");
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
