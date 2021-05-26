using ooplab1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ooplab1.devices {
    class Phone : Device {
        public readonly string producer;
        public readonly string model;
        public readonly double screenSize;
        public string os;

        public Phone(string producer, string model, double screenSize, string os) {
            this.producer = producer;
            this.model = model;
            this.screenSize = screenSize;
            this.os = os;
        }

        public override String ToString() {
            return "producer: " + this.producer + " model: " + this.model;
        }

        public override void TurnOn() {
            Console.WriteLine("Phone is turned on");
        }

        public override bool Sell(Human seller, Human buyer, double price) {
            return false;
        }
    }
}
