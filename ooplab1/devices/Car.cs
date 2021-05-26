using ooplab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1.devices {
    abstract class Car : Device {
        public Double engineSize;
        public String fuelType;

        public override void TurnOn() {
            Console.WriteLine("Engine does brrrrum");
        }

        public override bool Sell(Human seller, Human buyer, Double price) {
            if (seller.car != null) {
                if (buyer.cash >= price) {
                    buyer.cash -= price;
                    seller.cash += price;
                    buyer.car = seller.car;
                    seller.car = null;
                    Console.WriteLine("Car has been sold");
                    return true;
                }
            }
            Console.WriteLine("Car hasn't been sold");
            return false;
        }

        abstract public void Refuel();
    }
}
