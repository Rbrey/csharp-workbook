using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car
            Car arcticCar = new Car("white", 2);
            Car wizardCar = new Car("rainbow", 2);
            Car hippyCar = new Car("tiedye", 2);
            // Garage
            Garage largeGarage = new Garage(4);
            // People
            People lily = new People("Lily");
            People james = new People("James");
            People sue = new People("Sue");

            arcticCar.PlacePeople(lily, 0);
            arcticCar.PlacePeople(james, 1);
            wizardCar.PlacePeople(sue, 0);

            largeGarage.ParkCar(wizardCar, 0);
            largeGarage.ParkCar(arcticCar, 1);
            largeGarage.ParkCar(hippyCar, 3);

            Console.WriteLine(largeGarage.Cars);
            Console.WriteLine("");
            Console.WriteLine(arcticCar.Passengers);
            Console.WriteLine("");
            Console.WriteLine(wizardCar.Passengers);
        }
     }

     class Car
     {
         private People[] passengers;
         public Car(string initialColor, int size)
         {
             Color = initialColor;
             this.passengers = new People[size];
         }
         public string Color { get; private set; }
         public int size { get; private set; }
         public void PlacePeople (People person, int spot)
         {
             passengers[spot] = person;
         }
         public string Passengers
         {
             get 
             {
                 for (int i = 0; i < passengers.Length; i++)
                 {
                     if (passengers[i] != null)
                     {
                         Console.WriteLine(String.Format("{0} is in seat {1}.", passengers[i].Name, i));
                     }
                 }
                 return "That's all!";
             }
         }
     }

     class Garage
     {
         private Car[] cars;
         public Garage(int initialSize)
         {
             Size = initialSize;
             this.cars = new Car[initialSize];
         }
         public int Size { get; private set; }
         public void ParkCar (Car car, int spot)
         {
             cars[spot] = car;
         }
         public string Cars
         {
             get 
             {
                 for (int i = 0; i < cars.Length; i++)
                 {
                     if (cars[i] != null)
                     {
                         Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
                     }
                 }
                 return "That's all!";
             }
         }
     }
     
     class People
     {
         public People(string firstName)
         {
             Name = firstName;
         }
         public string Name { get; private set; }
     }
}
