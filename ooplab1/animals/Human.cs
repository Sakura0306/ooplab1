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
        public Car car;
        public Double cash;


        public static readonly String HUMAN_SPECIES = "homo sapiens";

        private Double salary;

        public Human(Double salary) : base(HUMAN_SPECIES) {
            this.SetSalary(salary);
        }

        public void GiveSalary() {
            this.cash += this.salary;
        }

        public Double GetSalary() {
            return this.salary;
        }

        public void SetSalary(Double newSalary) {
            if (newSalary > 0) {
                this.salary = newSalary;
            } else {
                Console.WriteLine("NOBODY WILL PAY FOR WORKING");
                this.salary = 0.0;
            }
        }
    }
}
