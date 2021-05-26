using ooplab1.devices;
using System;

namespace ooplab1 {
    class Program {
        static void Main(string[] args) {
            Animal dog = new Animal("dog");

            dog.name = "Szarik";

            dog.name = "Szarik";

            Human me = new Human(1000.0);
            me.firstName = "Kacper";
            me.lastName = "Warda";
            me.pet = dog;

            Phone onePlus = new Phone("onePlus",
                "8Pro",
                2.3,
                "Android");
            Phone iPhone6 = new Phone("Apple", "6s", 5.0, "iOs");

            Console.WriteLine("phone: " + onePlus);
            Console.WriteLine("phone: " + iPhone6);
            Console.WriteLine("human: " + me);

            onePlus.TurnOn();

            Car fiat = new Electric {
                engineSize = 1.9,
                fuelType = "disel",
                producer = "Fiat",
                model = "Bravo"
            };

            fiat.TurnOn();
            iPhone6.TurnOn();
            me.car = fiat;

            Console.WriteLine(me is Human);
            Console.WriteLine(me is Animal);

            Console.WriteLine(me.GetType());
            Console.WriteLine(me.GetType().BaseType.Name);

            Human buyer = new Human(2000.0);
            buyer.GiveSalary();

            me.car.Sell(me, buyer, 1000.0);


            Console.ReadKey();
        }
    }
}
