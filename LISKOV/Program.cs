// See https://aka.ms/new-console-template for more information
using LISKOV;

Console.WriteLine("Hello, World!");

Console.WriteLine("S.O.L.I.D = > LISKOV");

Console.WriteLine("-------------------------------------------");

ColdCoffee coldCoffee = new ColdCoffee();
Console.WriteLine(coldCoffee.MixColdOrIce());

HotCoffee hotCoffee = new HotCoffee();
hotCoffee.ServeCoffee();