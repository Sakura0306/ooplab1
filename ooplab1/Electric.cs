using ooplab1.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ooplab1 {
    class Electric : Car {
        public override void Refuel() {
            Console.WriteLine("Tanking");
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("... 2 hours later ...");
            Thread.Sleep(500);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("Charge level on 99%");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(500);
            Console.WriteLine("10 minutes later");
            Thread.Sleep(500);
            Console.WriteLine("...");
            Thread.Sleep(500);
            Console.WriteLine("Charged 100%");
        }
    }
}
