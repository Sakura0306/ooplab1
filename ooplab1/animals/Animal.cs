using System;
using System.Collections.Generic;
using System.Text;

namespace ooplab1 {
    public class Animal : Feedable {
        public static readonly Double DEFAULT_DOG_WEIGHT = 6.0;
        public String name;
        public static readonly Double DEFAULT_CAT_WEIGHT = 1.0;
        public static readonly Double DEFAULT_ELEPHANT_WEIGHT = 2000.0;
        public static readonly Double DEFAULT_WEIGHT = 0.5;
        public String species;
        private Double weight;

        public Animal(String species) {
            this.species = species;

            switch (species) {
                case "dog":
                    this.weight = DEFAULT_DOG_WEIGHT;
                    break;
                case "cat":
                    this.weight = DEFAULT_CAT_WEIGHT;
                    break;
                case "elephant":
                    this.weight = DEFAULT_ELEPHANT_WEIGHT;
                    break;
                default:
                    this.weight = DEFAULT_WEIGHT;
                    break;
            }

        }

        public void SetWeight(Double weight) {
            this.weight = weight;
        }

        public Double GetWeight() {
            return weight;
        }

        String ReturnSpeciesAndName() {
            return species + " " + name;
        }

        String ReturnNameAndOwner(String owner) {
            return name + " " + owner;
        }

        public void Feed() {
            Console.WriteLine("You didn't give me any food");
        }

        void Feedable.Feed(double foodWeight) {
            weight += foodWeight;
            Console.WriteLine("thx for food, bro");
            Console.WriteLine("my weight is now " + weight);
        }
    }
}
