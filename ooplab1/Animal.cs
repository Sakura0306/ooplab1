using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Animal {
        public readonly string Species = "canis";
        public string Name;
        private double weight = 3.0;

        public Animal(double weight) {
            this.weight = weight;
        }

        public void PrintWeight() {
            Console.WriteLine(weight);
        }

        public void TakeForAWalk() {
            if(weight <= 0.0) {
                Console.WriteLine("sorry, but the animal is desd");
            }
            else
            {
                weight = weight - 1.5;
            }
            
        }

        public void Feed(double foodWeight) {
            if(weight <= 0.0) {
                Console.WriteLine("sorry, but the animal is dead");
            }
            else
            {
                weight += foodWeight;
                Console.WriteLine("thx for food, bro");
                Console.WriteLine("my weight is now " + weight);
            }
           
        }

        public string ReturnSpeciesAndName() {
            return Species + " " + Name;
        }

        public string ReturnNameAndOwner(string owner) {
            return Name + " " + owner;
        }
    }
}
