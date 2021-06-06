using ooplab1.devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ooplab1 {
    class Human : Animal {
        public String firstName;
        public String lastName;
        public Animal pet;
        public Phone phone;
        public List<Car> garage;
        public decimal cash;


        public static readonly String HUMAN_SPECIES = "homo sapiens";

        private decimal salary;

        public Human(decimal salary, int size = 2) : base(HUMAN_SPECIES) {
            this.SetSalary(salary);
            this.garage = new List<Car>(size);
        }

        public void GiveSalary() {
            this.cash += this.salary;
        }

        public decimal GetSalary() {
            return this.salary;
        }

        public decimal getValueOfCars() {
            decimal value = 0.0m;
            foreach (Car car in garage) {
                value += car.value;
            }
            return value;
        }

        public List<Car> sortedCarsAsc() {
            List<Car> sortedCars = garage;
            sortedCars.Sort(delegate (Car a, Car b) {
                return a.CompareTo(b);
            });
            return sortedCars;
        }

        public Car getCar(int parkingspot) {
            return garage[parkingspot];
        }

        public void setCar(Car car, int parkingspot) {
            garage[parkingspot] = car;
        }

        public void SetSalary(decimal newSalary) {
            if (newSalary > 0) {
                this.salary = newSalary;
            } else {
                Console.WriteLine("NOBODY WILL PAY FOR WORKING");
                this.salary = 0.0m;
            }
        }
    }
}
