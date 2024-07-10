namespace Polymorphism;
public class Duck{

    public string wings{ get; set;}
    public int weight{ get; set;}

    //Virtual keyword allows us to override the parent method
    public virtual void Swim(){
        Console.WriteLine("Duck is swimming");
    }

    public void Quack(){
        Console.WriteLine("Duck is quacking");
    }


}