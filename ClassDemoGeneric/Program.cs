// See https://aka.ms/new-console-template for more information
using ClassDemoGeneric.model;
using ClassDemoGeneric.DrinkKort;
using System.Net.WebSockets;

Console.WriteLine("Hello, World!");


Kort kort = new Kort();
kort.InsertFirst(new Drink(3, "G'n'T", "......"));
kort.InsertFirst(new Drink(5, "coke'n'rhum", "......"));
foreach(Drink d in kort.Drinks())
{
    Console.WriteLine(d);
}


/*
 * nu med generics
 */
Console.WriteLine(  "Her med generics");
KortGeneric<Drink> kortgen = new KortGeneric<Drink>();
kortgen.InsertFirst(new Drink(3, "G'n'T", "......"));
kortgen.InsertFirst(new Drink(5, "coke'n'rhum", "......"));
foreach (Drink d in kortgen.AllItems())
{
    Console.WriteLine(d);
}



Kage kage1 = new Kage(1, "snegl", 15);
Kage kage2 = new Kage(2, "croissant", 18);
KortGeneric<Kage> kageKort = new KortGeneric<Kage>();
kageKort.InsertFirst(kage1);
kageKort.InsertFirst(kage2);
foreach (Kage d in kageKort.AllItems())
{
    Console.WriteLine(d);
}

