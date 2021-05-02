﻿using System;

namespace OOPlab1 {
    class Program {
        static void Main(string[] args) {
            Animal dog = new Animal(10.0);

            dog.Name = "Szarik";

            dog.Feed(2.0);

            string text = dog.ReturnSpeciesAndName();
            Console.WriteLine(text);
            text += " afawefawfawe";
            Console.WriteLine(text);

            String nameAndOwner = dog.ReturnNameAndOwner("Kacper");
            Console.WriteLine(nameAndOwner);

            Human me = new Human();
            me.FirstName = "Kacper";
            me.LastName = "Warda";
            me.Pet = dog;

            dog.Feed(1.0);
            dog.PrintWeight();

            me.Phone = new Phone("onePlus",
                "8Pro",
                2.3,
                "Android");
            Console.WriteLine(me.Phone.Model);

            me.Phone = new Phone("apple", "6s", 5.0, "iOs");
            me.Salary = 10000.0m;
            Console.WriteLine(me.Salary);
            me.Salary = 100.0m;
            Console.WriteLine(me.Salary);
            me.Salary = -10.0m;
            Console.WriteLine(me.Salary);
            Console.WriteLine(me.Phone.Model);

            Console.ReadKey();
        }
    }
}
