using System;
namespace Transportation{
namespace Vehicles {
    public class Auto {
        public string make;
        public string model;

        public Auto(){
            make="Unknown";
            model="Unknown";
        }
        public Auto(string make,string model){
            this.make= make;
            this.model= model;
        }

    }
    class Program{
        static void Main(string [] args ){
            Auto car1 = new Auto("Toyota","Yaris");
            Console.WriteLine($"Car: {car1.make} {car1.model}");
        }
    }
}
}