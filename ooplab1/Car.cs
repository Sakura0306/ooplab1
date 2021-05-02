using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab1 {
    class Car {
        public string make;
        public string model;
        public decimal value;
        public string colour;
        public string brand;
        public DateTime year;
        public decimal mileage;
        private string _type;
        public override string ToString() {
            return $"the {brand} made in {year} has {mileage} travelered";
        }

        public override bool Equals(Object obj) {
            Car c = (Car)obj;   
            return this.make == c.make && this.model == c.model;
        }

        public override int GetHashCode() {
            return Tuple.Create(make, model).GetHashCode();
        }

        public string Type {
            get { 
                return _type; 
            }
        }
    }
}
