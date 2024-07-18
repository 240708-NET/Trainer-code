## EF CORE

Entity Framework Core (EF Core) is an object-relational mapper (ORM).

An ORM provides a layer between the domain model that you implement in code and a database. EF Core is a data access API that allows you to interact with the database by using.

## Migration

Since data models changes as new features are implemented, new entities are created and added, so we need to update schemas. 

It is a powerful feature that automates the process of updating a database schema to match changes in your application's data model. 

**Migrations** are a way to incrementally update the database schema to reflect changes in your DbContext and entity classes.

### Migration workflow

**Prepreq**

Install packages

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-ef
```

```csharp
//Add Connection string to appsettings.json
 "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=YourDatabase;User=sa;Password=NotPassword123!;TrustServerCertificate=true;"
  },


  // Best practice to store your connection string in user secrets
  dotnet tool install --global dotnet-user-secrets
  dotnet user-secrets init
   dotnet user-secrets set "Server=locahost;Database=demoDB;User Id=sa;Password=yoursuperpassword!24;Trusted_Connection=True;TrustServerCertificate=true;"

```

**1. Adding a migration**

```
dotnet ef migrations add <Name>
```
This generates a migration file with Up and Down methods that describe how to apply and revert the schema changes.

**2.Applying Migrations**

```
dotnet ef database update
```
This command executes the Up methods of all pending migrations, thereby updating the database schema.

**3.Rolling Back Migrations:**

```
dotnet ef database update <LastMigrationName>
```

**Benefits of EF Core Migration**
- **Automated Schema Management:** Simplifies the process of synchronizing database schema changes with application changes.

- **Version Control Integration:** Migration files can be version-controlled, enabling collaborative development and easy deployment.
- **Cross-Platform Support:** Works seamlessly across different database providers and operating systems supported by .NET Core.