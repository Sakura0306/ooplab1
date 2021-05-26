using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1 {
    class FarmAnimal : Animal, IEdible {

        public FarmAnimal(String species) : base(species) {
        }

        Double IEdible.Eat() {
            if (base.GetWeight() < 0) {
                Console.WriteLine("Can't be eaten");
                return 0.0;
            } else {
                Double temp = base.GetWeight();
                base.SetWeight(0.0);
                return temp;
            }
        }
    }
}
