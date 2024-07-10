# OOP

Object-Oriented Programming (OOP) is a programming paradigm based on the concept of "objects", which can contain data, in the form of fields 
(often known as attributes or properties), and code, in the form of procedures (often known as methods). 
OOP focuses on the creation of reusable and modular code by organizing it into objects that interact with each other.

## Benefits of OOP approach

- **Modularity**: OOP promotes modular design, making it easier to maintain and update code.
- **Reusability**: Classes and objects can be reused in different parts of the program or in different programs altogether.
- **Scalability**: OOP allows for easier scaling of applications by breaking them down into smaller, manageable objects.

### Key Concepts of OOP:

1. **Classes and Objects:**
   - **Class:** A blueprint or template for creating objects. It defines the properties (attributes) and behaviors (methods) that objects of the class should have.
   - **Object:** An instance of a class. It is a concrete entity created based on the class definition.

2. **Encapsulation:**
   - Encapsulation is the bundling of data (attributes) and methods that operate on the data into a single unit (class).
   It allows for the hiding of internal state and requires interaction with the object to be performed through well-defined interfaces (methods).

  **In C# encapsulation reffers to acccess modifiers sush as private, public and protected.**

3. **Inheritance:**
   - Inheritance allows one class (subclass/derived class) to inherit the properties and behaviors of another class (superclass/base class).
  It promotes code reuse and allows the creation of a hierarchy of classes.

  **As an example, we can have class Canine as a parent(base) class with a certain fetures, and classes dogs and wolfs as children**

4. **Polymorphism:**
   - Polymorphism means the ability to take on many forms. In OOP, polymorphism allows objects of different classes to be treated as objects of a common superclass.
     **It is typically achieved through method overriding and method overloading.**

5. **Abstraction**
  - focuses on hiding complex implementation details and exposing only the necessary parts to the user.
In C#, abstraction is primarily achieved through abstract classes and interfaces.

### Abstract class and Interfaces

**Abstract class**:
- cannot be instantiated directly. It is marked with the abstract keyword.
- can include both abstract (methods without implementation) and non-abstract (methods with implementation) members.
- Abstract classes can have fields, constructors, and properties.

We use this class in a chain with inheritance, like class Animal is abstract; 
it is not specific, but we might have class Wolf, cat, or lion, which can be a specific implementation of the class.

**Interface**:
- An interface in C# defines a contract for classes. It contains only the declaration of methods, properties, events, or indexers but not the implementation.
- Interfaces cannot have fields, constructors, or method definitions.
- They used to define functionality that a class must implement.
- They provide a way to achieve multiple inheritance in C# (a class can implement multiple interfaces).

#### Key differences between them
Abstract Class:

- Can have both abstract and non-abstract members.
- Can contain fields, constructors, and properties.
- A class can inherit only one abstract class.

Interface:

- Contains only method signatures, properties, events, or indexers without any implementation.
- Cannot contain fields, constructors, or method implementations.
- A class can implement multiple interfaces.