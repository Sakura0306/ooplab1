using ooplab1.devices;
using System;

namespace ooplab1 {
    class Program {
        static void Main(string[] args) {
            Animal dog = new Animal("dog");

            dog.name = "Szarik";

            dog.name = "Szarik";

            Human me = new Human(1000.0m);
            me.firstName = "Kacper";
            me.lastName = "Warda";
            me.pet = dog;

            Human humanA = new Human(1500.0m);
            humanA.name = "humanA";
            Human humanB = new Human(900.0m);
            humanB.name = "humanB";
            Human humanC = new Human(700.0m);
            humanC.name = "humanC";
            Human humanD = new Human(1600.0m);
            humanD.name = "humanD";
            humanA.GiveSalary();
            humanB.GiveSalary();
            humanC.GiveSalary();
            humanD.GiveSalary();


            Phone onePlus = new Phone("onePlus",
                "8Pro",
                2.3,
                "Android");
            Phone iPhone6 = new Phone("Apple", "6s", 5.0, "iOs");

            Console.WriteLine("phone: " + onePlus);
            Console.WriteLine("phone: " + iPhone6);
            Console.WriteLine("human: " + me);

            onePlus.TurnOn();

            Car fiat = new Diesel {
                engineSize = 1.9,
                fuelType = "disel",
                producer = "Fiat",
                model = "Bravo",
                value = 1200.0m
            };

            Car fiathumanA = new Diesel {
                engineSize = 1.9,
                fuelType = "disel",
                producer = "Fiat",
                model = "Bravo",
                value = 700.0m
            };

            Car fiat2 = new Diesel {
                engineSize = 1.9,
                fuelType = "disel",
                producer = "Fiat",
                model = "Bravo",
                value = 1500.0m
            };

            humanA.garage.Add(fiathumanA);

            humanA.garage[0].Sell(humanA, humanB, humanA.garage[0].value);
            humanB.garage[0].Sell(humanB, humanC, humanB.garage[0].value);
            humanC.garage[0].Sell(humanC, humanA, humanC.garage[0].value);
            humanA.garage[0].Sell(humanA, humanD, humanA.garage[0].value);

            Console.WriteLine(humanD.garage[0].soldTimes());

            Console.WriteLine(humanD.garage[0].wasSoldOrderCorrect(humanC, humanB));

            foreach (Transaction trans in humanD.garage[0].transactions) {
                trans.printTransaction();
            }


            fiat.TurnOn();
            iPhone6.TurnOn();
            me.garage.Add(fiat);
            me.garage.Add(fiat2);

            foreach (Car car in me.sortedCarsAsc()) {
                Console.WriteLine(car.model + ' ' + car.GetYearOfProduction());
            }


            Console.WriteLine(me is Human);
            Console.WriteLine(me is Animal);

            Console.WriteLine(me.GetType());
            Console.WriteLine(me.GetType().BaseType.Name);

            Human buyer = new Human(2000.0m);
            buyer.GiveSalary();

            me.garage[0].Sell(me, buyer, me.garage[0].value);
            me.garage[1].Sell(me, buyer, me.garage[1].value);


            Console.ReadKey();
        }
    }
}
