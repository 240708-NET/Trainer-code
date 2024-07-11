### xUnit Testing Framework

---

### Type of Testing

- **Unit Tests** - testing individual methods and functions of the classes, components, or modules used by your software.
- **Integration  Tests** - verify that different modules or services used by your application work well together. For example, it can be testing the interaction with the database or making sure that microservices work together as expected
- **Functional  Tests** -  focus on the business requirements of an application. They only verify the output of an action and do not check the intermediate states of the system when performing that action.
- **Performance testing** -  evaluate how a system performs under a particular workload. These tests help to measure the reliability, speed, scalability, and responsiveness of an application


### Test-Driven Development 

Consists of writing unit tests first, before the implemented application code has been written. Then, the implemented application code can be written to make the test pass and the process can be completed for each piece of functionality required.

### Unit Testing

Unit testing is a software testing technique where individual units or components of a software application are tested in isolation from the rest of the codebase. A unit typically refers to the smallest testable part of an application, such as a method, function, or class.

**Benefits**
- Early Bug Detection
- Code Quality Assurance
- Regression Testing




**Introduction to xUnit**

 Developed as an open-source project, xUnit.net is widely used for testing .NET applications, providing a rich set of features and capabilities to ensure the reliability and correctness of your code.

 
  ### AAA Pattern

- **Arrange** - sets up the necessary preconditions and inputs for the test.

```
// Arrange
int a = 3;
int b = 5;
int expected = 8;
```

- **Act** -  executes the actual operation or method being tested with the inputs
```
// Act
int actual = MathUtils.Add(a, b);
```
- **Assert** -  verifies the expected outcomes or behaviors of the unit under test based
```
  // Assert
 Assert.Equal(expected, actual);
```

**Anatomy of a Unit Test in xUnit**

Let's look at how a typical unit test is structured in an xUnit framework:

```csharp
using Xunit;

public class StringHelperTests
{
    [Fact]
    public void Test_ToUpperCase()
    {
        // Arrange
        string input = "hello";

        // Act
        string result = input.ToUpper();

        // Assert
        Assert.Equal("HELLO", result);
    }

    [Fact]
    public void Test_IsStringEmpty()
    {
        // Arrange
        string input = "";

        // Act
        bool isEmpty = string.IsNullOrEmpty(input);

        // Assert
        Assert.True(isEmpty);
    }
}


```

### Fact vs Theory

[Fact] - Typically used for tests that have a fixed set of inputs and expected outputs, and the test logic does not change based on different scenarios.
[Theory] -  used when you want to run the same test logic with different data inputs, which are provided by data attributes (like [InlineData] or [MemberData]).

### Create and Connect xUnit.net with C# project

1. Create a solution that contains your project and test for the project.

```csharp
dotnet new sln -o demoXunit
```

2. Change directory with  ```cd demoXunit```

3. Create your project with:

```csharp
dotnet new console -o projectName

or

dotnet new classlib -o projectName

```

4. Add this project to your solution
```csharp
dotnet sln add ./projectName/projectName.csproj

```

5. Create a Xunit test 
```csharp
dotnet new xunit -o projectName.Tests

```
6. Add test project to the solution

```csharp
dotnet sln add ./projectName.Tests/projectName.Tests.csproj

```
7. Add your project as a dependency to Test project

```csharp
dotnet add ./projectName.Tests/projectName.Tests.csproj reference ./projectName/projectName.csproj
```