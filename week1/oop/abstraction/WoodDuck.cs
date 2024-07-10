namespace Abstraction;
public class WoodDuck : Duck, IDuck {

    //Override abstract method
    public override void Swim(){
        Console.WriteLine("Wood Duck is swimming");
    }

    public void fly(){

       Console.WriteLine("I am flying");

    }


}