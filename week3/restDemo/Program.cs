using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<User> users = new List<User>();

users.Add(new User(1, "John", "Doe"));
users.Add(new User(2, "Jane", "Doe"));

//List all users
app.MapGet("/users", () => users);

//Get by ID
app.MapGet("/users/{id}", (int id) => {
    var user = users.FirstOrDefault(user => user.Id == id);
    if(user != null){
        return Results.Ok(user);
    }
    else{
        return Results.NotFound("User with this id does not exist");
    }
});


//Create user
app.MapPost("/users/", ([FromBody] User user) => {
    users.Add(user);
    return Results.Created($"User {user.Firstname} added successfully", user);
}); 

// Update user First name
app.MapPatch("/users/Rename/{id}", (int id) => {
    string newName = "Kate";
    var user = users.FirstOrDefault(user => user.Id == id);
     if(user != null){
        user.Firstname = newName;
        return Results.Ok($"User with id {id} was renamed");
    }
    else{
        return Results.NotFound("User with this id does not exist");
    }


});



// Delete user
app.MapDelete("/users/DeleteUser/{id}", (int id) => {
    var user = users.FirstOrDefault(user => user.Id == id);
    if(user != null){
        users.Remove(user);
        return Results.Ok($"User with id {id} was removed");
    }
    else{
        return Results.NotFound($"User with id {id} does not exist");

    }
});


app.Run();
