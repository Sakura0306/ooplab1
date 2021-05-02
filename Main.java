package com.company;

public class Main {

    public static void main(String[] args) {

       Animal dog = new Animal();
       dog.name = "Szarik";

       dog.feed(2.0);

       String text = dog.returnSpeciesAndName();
       System.out.println(text);
       text += " afawefawfawe";
       System.out.println(text);

       String nameAndOwner = dog.returnNameAndOwner("Kacper");
       System.out.println(nameAndOwner);

       Human me = new Human();
       me.firstName = "Kacper";
       me.lastName = "Warda";
       me.pet = dog;


       dog.feed(1.0);
       dog.printWeight();

       Phone onePlus = new Phone("onePlus",
               "8Pro",
               2.3,
               "Android");

       System.out.println(me.phone.model);

       me.phone = new Phone("apple", "6s",  5.0,  "iOs");

       System.out.println(me.phone.model);














    }
}
