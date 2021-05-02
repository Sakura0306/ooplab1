using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Human {
        public string FirstName;
        public string LastName;
        public Animal Pet;
        public Phone Phone;
        public int Number;
        private DateTime salaryModificationDate;
        private decimal salary;

        private Car ownedCar;

        public decimal Salary {
            get {
                Console.WriteLine(salaryModificationDate);
                return salary;
            }
            set {
                if(value > 0) {
                    salaryModificationDate = DateTime.Now;
                    salary = value;
                    Console.WriteLine("Added new salary");
                }
           
            }
        }
        private string GetCar(Car car) {
            if (this.salary > car.value) {
                if (this.ownedCar != null && ownedCar == car) {
                    this.ownedCar = car;
                    return ("Car added");
                } else {
                    return ("you try to add the same car");
                }
            } else {
                return ("Car can't be added");
            }
        }
    }
}
