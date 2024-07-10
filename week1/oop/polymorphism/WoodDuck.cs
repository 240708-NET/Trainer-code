namespace Polymorphism;

public class WoodDuck : Duck {

    //Override the parent
    public override void Swim(){
        Console.WriteLine("I don't want to swim!");
    }

    // Overloading 

    public void fly(){
        Console.WriteLine("I am flying");
    }

    public void fly(int number){

        for(int i = 0; i < number; i++){
            Console.WriteLine("I am flying");
        }
    }

    public void fly(string name){

        Console.WriteLine(name);
    }
}