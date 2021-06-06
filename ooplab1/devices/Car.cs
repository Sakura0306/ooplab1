using ooplab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1.devices {
    abstract class Car : Device, IComparable<Car> {
        public Double engineSize;
        public String fuelType;
        public List<Human> owners;
        public List<Transaction> transactions;

        public override void TurnOn() {
            Console.WriteLine("Engine does brrrrum");
        }

        public Human getCurrentOwner() {
            return owners[owners.Count-1];
        }

        public int CompareTo(Car car) {
            if (car == null)
                return 1;
            if (this.GetYearOfProduction() == car.GetYearOfProduction()) {
                return 0;
            } else if (this.GetYearOfProduction() < car.GetYearOfProduction()) {
                return -1;
            } else {
                return 1;
            }
        }

        public static bool operator <(Car car1, Car car2) {
            return car1.CompareTo(car2) < 0;
        }

        public static bool operator >(Car car1, Car car2) {
            return car1.CompareTo(car2) > 0;
        }

        public Car compareCars(Car car) {
            return this.GetYearOfProduction() > car.GetYearOfProduction() ? this : car;
        }

        public bool hasBeenAnOwner(Human checker) {
            foreach (Human owner in owners) {
                if (owner == checker) {
                    return true;
                }
            }
            return false;
        }

        public bool wasSoldOrderCorrect(Human buyerCheck, Human sellerCheck) {
            for (int i = 0; i < owners.Count - 2; i++) {
                if (owners[i] == buyerCheck) {
                    if (owners[i + 1] == sellerCheck) {
                        return true;
                    }
                }
            }
            return false;
        }

        public int soldTimes() {
            return this.owners.Count - 1;
        }

        public override bool Sell(Human seller, Human buyer, decimal price) {
            if (seller.garage != null) {
                int position = seller.garage.IndexOf(this);
                if (seller.garage[position] != null) {
                    if (buyer.cash >= price) {
                        if(buyer.garage.Capacity > buyer.garage.Count) {
                            if(owners[owners.Count-1] == seller) {
                                buyer.cash -= price;
                                seller.cash += price;
                                buyer.garage.Add(seller.garage[position]);
                                seller.garage[position] = null;
                                Console.WriteLine("Car has been sold");
                                this.transactions.Add(new Transaction(seller, buyer, price, DateTime.Now));
                                this.owners.Add(buyer);
                                return true;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Car hasn't been sold");
            throw new Exception();
        }

        abstract public void Refuel();

    }
}
