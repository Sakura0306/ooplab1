using ooplab1.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ooplab1 {
    class Petrol : Car {
        public override void Refuel() {
            Console.WriteLine("Tanking"); 
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("done");

        }
    }
}
