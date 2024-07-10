/*
using Inheritance;
WoodDuck myDuck = new WoodDuck();

myDuck.Swim();


using Polymorphism;


WoodDuck myDuck = new WoodDuck();
//Demonstrate override

myDuck.Swim();

//Demonstrate overloading
myDuck.fly();
myDuck.fly(2);
myDuck.fly("Shrek");
*/

//Demo Abstraction
using Abstraction;
RubberDuck Dean = new RubberDuck();
WoodDuck Sam = new WoodDuck();

Dean.Swim();

Sam.Swim();
Sam.fly();
Dean.Quack();