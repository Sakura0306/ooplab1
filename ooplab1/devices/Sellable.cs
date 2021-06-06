using ooplab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1.devices {
    interface ISellable {
        bool Sell(Human seller, Human buyer, decimal price);
    }
}
