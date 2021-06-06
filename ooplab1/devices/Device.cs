using ooplab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1.devices {
    abstract class Device : ISellable {
        public String producer;
        public String model;
        public decimal value;
        private int yearOfProduction;

        public int GetYearOfProduction() {
            return yearOfProduction;
        }

        public virtual bool Sell(Human seller, Human buyer, decimal price) {
            throw new NotImplementedException();
        }

        public void SetYearOfProduction(int yearOfProduction) {
            this.yearOfProduction = yearOfProduction;
        }

        public abstract void TurnOn();
    }
}
