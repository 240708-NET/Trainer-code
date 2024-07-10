namespace Abstraction;
public abstract class Duck{

    public abstract void Swim();

    //Default method that will be inherited by derived classes
    public void Quack(){
        Console.WriteLine("Duck is quacking");
    }


}