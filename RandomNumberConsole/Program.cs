using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // not truly random if you know the seed number
            Random randomNumber = new Random(10);

            List<PersonModel> people = new List<PersonModel>()
            {
                new PersonModel() {Age=1,Name="Adam"},
                new PersonModel() {Age=2,Name="Bob"},
                new PersonModel() {Age=3,Name="Candor"}
            };

            var shuffledPeople = people.OrderBy(x=>randomNumber.Next()).ToList();
            shuffledPeople.ForEach(x => Console.WriteLine(x.Name));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomNumber.Next(5,11));
                Console.WriteLine(randomNumber.NextDouble()*10);
            }
            Console.ReadLine();
        }

    }

    internal class PersonModel
    {
        public string Name;
        public int Age;


    }
}
