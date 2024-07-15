# Design Patterns and SOLID

## Introduction to Design Patterns

Design patterns are proven solutions to recurring problems in software design. 

They provide a structured approach to solving common issues, promoting code reusability, maintainability, and scalability. 

---

## Separation of Concerns

Separation of Concerns (SoC) is a software design principle that advocates separating a computer program into distinct sections, each addressing a specific concern or aspect of functionality. 

**1. Single Responsibility** - Each module, class, or function should have responsibility over a single part of the functionality provided by the software.

Example: A class that handles database operations should not also be responsible for user authentication.

**2. Modularity** - Breaking down a system into smaller, self-contained modules that can be developed, tested, and maintained independently.

Example: A web application divided into modules for user management, product catalog, and order processing.

**3. Reduced Complexity** - By separating concerns, each part of the system becomes simpler and easier to understand, reducing the overall complexity of the software.

Example: A user interface component focuses only on displaying data and handling user interactions, without directly manipulating business logic.

## SOLID
- S - Single Responsibility Principle (SRP)
 
 **A class should have only one reason to change, meaning that it should have only one job.**
- O - Open/Closed Principle (OCP)

 **Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.**

 **Example:** Using inheritance or interfaces to allow new behaviors without modifying existing code.

- L - Liskov Substitution Principle (LSP)

**Objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program.**

Example: Ensuring that derived classes can be substituted for their base classes.
- I - Interface Segregation Principle (ISP)

**Clients should not be forced to depend on interfaces they do not use.**
- D - Dependency Inversion Principle (DIP)

**High-level modules should not depend on low-level modules. Both should depend on abstractions.**

So it means classes should rely on interfaces or abstract class rather than concrete implementations.

## Dependency Injection


Dependency Injection (DI) is a design pattern, where Instead of a class creating its own dependencies, these dependencies are provided (injected) from the outside. 

```csharp
// Service interface
public interface IMessageService
{
    void SendMessage(string message);
}

// Service implementation
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

// Consumer class with dependency injection
public class NotificationService
{
    private readonly IMessageService _messageService;

    // Constructor injection
    public NotificationService(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void SendNotification(string message)
    {
        // Use the injected service
        _messageService.SendMessage(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using dependency injection
        IMessageService messageService = new EmailService(); // Dependency
        NotificationService notificationService = new NotificationService(messageService);

        // Sending notification
        notificationService.SendNotification("Hello, world!");
    }
}


```

## Design Patterns

### Creational Patterns

#### Singleton Pattern

- **Purpose**: Ensure a class has only one instance and provide a global point of access to it.
- **Example in C#**:
  ```csharp
  public class Singleton
  {
      private static Singleton instance;
      
      private Singleton() { }
      
      public static Singleton Instance
      {
          get
          {
              if (instance == null)
              {
                  instance = new Singleton();
              }
              return instance;
          }
      }
  }

**Main idea - we have only one instance of the class.**
Commong example: Loggers, Configuration Management, Caching, Database Connection Pool, User Session Management

#### Factory Method Pattern
Purpose: Define an interface for creating objects, but let subclasses decide which class to instantiate.

```csharp
public interface IPizza
{
    void Bake();
    void Box();
}

public class MargheritaPizza : IPizza
{

    public void Bake()
    {
        Console.WriteLine("Baking Margherita pizza...");
    }

    public void Box()
    {
        Console.WriteLine("Putting Margherita pizza in a box...");
    }
}

public class PepperoniPizza : IPizza
{

    public void Bake()
    {
        Console.WriteLine("Baking Pepperoni pizza...");
    }

    public void Box()
    {
        Console.WriteLine("Putting Pepperoni pizza in a box...");
    }
}

public interface IPizzaFactory
{
    IPizza CreatePizza(string type);
}

public class SimplePizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza(string type)
    {
        IPizza pizza = null;

        // Create different types of pizzas based on the type parameter
        switch (type.ToLower())
        {
            case "margherita":
                pizza = new MargheritaPizza();
                break;
            case "pepperoni":
                pizza = new PepperoniPizza();
                break;
            default:
                throw new ArgumentException($"Unknown pizza type: {type}");
        }

        return pizza;
    }
}

public class PizzaStore
{
    private readonly IPizzaFactory _pizzaFactory;

    public PizzaStore(IPizzaFactory pizzaFactory)
    {
        _pizzaFactory = pizzaFactory;
    }

    public void OrderPizza(string type)
    {
        IPizza pizza = _pizzaFactory.CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        Console.WriteLine($"Here's your {type} pizza!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPizzaFactory pizzaFactory = new SimplePizzaFactory();
        PizzaStore pizzaStore = new PizzaStore(pizzaFactory);

        pizzaStore.OrderPizza("Margherita");
        pizzaStore.OrderPizza("Pepperoni");

        Console.ReadLine();
    }
}

```
