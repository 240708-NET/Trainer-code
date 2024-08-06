namespace patientTracker.Data.Repositories;

using System.Runtime.CompilerServices;
using patientTracker.Models;

public interface IUserRepo{

    //Get all users
    public Task<List<User>> GetAllUsers();

    //Create a user
    public Task<User> CreateUser(User user);

    //Get user by id
    public Task<User?> GetUserById(int id);

    //Get user by username
    public Task<User?> GetUserByUsername(string username);
    
    //Update user password
    public Task<User> UpdateUser(User user);

    //Delete user
    public Task Delete(User selectedUser);

}