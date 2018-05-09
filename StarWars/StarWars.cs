using System;

namespace StarWars
{
    class Program
    {
        static void Main()
        {
            Person rebel = new Person("Leia", "Organa", "Rebel");
            Person rebel = new Person("Luke", "Skywalker", "Rebel");
            Person imperial = new Person("Darth", "Vader", "Imperial");
            Ship xwing = new Ship("Rebel", "Fighter", 1);
            Ship falcon = new Ship("Rebel", "Smuggling", 2);
            Ship tie = new Ship("Imperial", "Fighter", 1);
            Station RBS = new Station("Rebel Space Station", "Rebel", 1);
            Station DS = new Station("Death Star", "Imperial", 2);
            Console.WriteLine("Hello World!");

            int[] nums = new int[3] {1, 2, 3};
            Console.WriteLine(nums.Length);
        }
    }
     class Person
     {
         private string firstName;
         private string lastName;
         private string alliance;
         public Person(string firstName, string lastName, string alliance)
         {
            this.firstName = firstName;
            this.lastName = lastName;
            this.alliance = alliance;
         }
         public string FullName
         {
            get
            {
                return this.firstName + " " + this.lastName;
            }
            set
            {
                string[] names = value.Split(' ');
                this.firstName = names[0];
                this.lastName = names[1];
            }
         }
     }
     class Ship
     {
         private Person[] passengers;

         public Ship(string alliance, string type, int size)
         {
             this.Type = type;
             this.Alliance = alliance;
             this.passengers = new Person[size];
         }

        public string Type { get; set; }
        public string Alliance { get; set; }
        public string Passengers
        {
            get
            {
                foreach (var person in passengers)
                {
                    Console.WriteLine(String.Format("{0}", person.FullName));
                }
                return "That's Everybody!";
            }
        }

        public void EnterShip(Person person, int seat)
        {
            this.passengers[seat] = person;
        }
        public void ExitShip(int seat)
        {
            this.passengers[seat] = null;
        }
     }
     
     class Station
     {
         private string Name;
         private int Docks;

         public Station (string Name, string Alliance, int Docks)
         {
             this.Name = name;
             this.Docks = docks;
         }
         public string Alliance { get; set; }
     }
}
