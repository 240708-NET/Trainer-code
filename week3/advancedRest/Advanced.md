# Advanced REST

## Caching
**Caching** refers to the process of storing frequently used data so that those data can be served much faster for any future requests. 


### **In-memory caching**
In-memory caching uses server memory to store cached data. This type of caching is suitable for a single server or multiple servers using session affinity. 

Session affinity is also known as sticky sessions. Session affinity means that **the requests from a client are always routed to the same server for processing.**


### **Distributed Cache**
Extends in-memory caching by allowing data to be stored across multiple servers or instances. 
The cache is **shared across the servers** that process requests.

The simples way to work with chache is use In-memory class
```bash
Install-Package Microsoft.Extensions.Caching.Memory
```

```csharp
using Microsoft.Extensions.Caching.Memory;
using System;

public class Program
{
    public static void Main()
    {
        // Create a new instance of MemoryCache
        var cache = new MemoryCache(new MemoryCacheOptions());

        // Add data to the cache
        cache.Set("cacheKey", "cached data", TimeSpan.FromSeconds(30)); // Cache for 30 seconds

        // Retrieve data from the cache
        if (cache.TryGetValue("cacheKey", out string cachedData))
        {
            Console.WriteLine("Data from cache: " + cachedData);
        }
        else
        {
            Console.WriteLine("Data not found in cache.");
        }
    }
}

```

**Link**: https://learn.microsoft.com/en-us/dotnet/framework/performance/caching-in-net-framework-applications



## Open AI

It is a specification for building and documenting RESTful APIs. It defines a standard way to describe the functionalities of an API, including its endpoints, request and response formats, authentication methods, and more. 


```
dotnet add package Swashbuckle.AspNetCore  -- add Swagger
http://localhost:5270/swagger/index.html
```

Link: https://www.openapis.org/what-is-openapi
Link: https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-8.0
Link:https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-8.0&tabs=visual-studio-code

## Routing

Routing  refers to the process of mapping incoming HTTP requests to application endpoints, typically to execute specific actions or return responses. 

In ASP.NET Core, routing is a fundamental part of handling HTTP requests and involves defining routes that match specific patterns in URLs. 

```csharp
endpoints.MapGet("/hello", async context =>
{
    await context.Response.WriteAsync("Hello, World!");
});

//Controller.cs
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        // Logic to retrieve user
        return Ok(user);
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] User user)
    {
        // Logic to create user
        return Created("/api/users/" + user.Id, user);
    }
}

```

In other words, **routing** in .NET provides a structured way to handle incoming HTTP requests by defining routes that map URLs to actions or methods in controllers.

## Cross Origin Sharing

**Cross-Origin Resource Sharing (CORS)** is a security feature implemented by web browsers that allows servers to specify which origins (websites) are permitted to access the resources (like APIs) on their server. 

This security feature prevents web pages from making requests to a different domain than the one that served the web page, which is known as the same-origin policy.


```csharp
var builder = WebApplication.CreateBuilder(args);

const string policyName = "CorsPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName, builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

...

app.UseAuthentication();
app.UseAuthorization();

app.UseCors(policyName);

app.MapControllers();

app.Run();

```

**Link**: https://code-maze.com/enabling-cors-in-asp-net-core/
**Link**: https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-8.0

## Session Management

**Sessions** are typically used to store information about a client in the interest of improving the user experience: authentication, customized recommendations, shopping carts, and more.

All of these require the server to store details of prior interactions with the client. And because the client can change (difference device, web browser, etc.) the only consistent place to store this state is on the server.

**Link**: https://www.baeldung.com/cs/web-sessions

## Http Cookies
Cookies are small pieces of data stored on a user's device (typically in their web browser) by websites they visit. Cookies are used to remember stateful information or to track users' activities across different pages or sessions on a website. It has a structur

- **Session Management**: remember login status or items in a shopping cart during a single browsing session.
- **Personalization**: user preferences and settings to personalize the user experience

- **Tracking**: Tracking user behavior and activities (tracking cookies) for analytics, advertising, or marketing purposes.

## Authorization vs Authentication
These are closely related concepts in the context of security and access control, especially in software systems and applications. 

<span style="color:#F47F01; font-weight:bold">Authentication</span> is the process of verifying the identity of a user or entity attempting to access a system or application. 

It ensures that the user is who they claim to be before granting access to resources or functionalities. 

**Example**: Log in to a websiite using your username and password, the system verifies that the provided credentials match an authorized user's credentials stored in its database. If they match, you are authenticated and granted access.

<span style="color:#F47F01; font-weight:bold">Authorization</span> is the process of determining what actions or operations an authenticated user or entity is allowed to perform within a system or application. 

- **Authentication** - **who are you** 
- **Authorization** - **f you have access to a certain resource.**

Dotnet has a ASP.NET Core Identity feature, that allows you to build web app with authentication
Link: https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-8.0&tabs=visual-studio
