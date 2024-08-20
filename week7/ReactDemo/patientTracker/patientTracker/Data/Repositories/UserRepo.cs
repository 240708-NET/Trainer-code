namespace patientTracker.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using  patientTracker.Models;

public class UserRepo : IUserRepo{

    public readonly PatientTrackerContext _context;

    public UserRepo(PatientTrackerContext context){
        _context = context;
    }

 //Get all users
    public async Task<List<User>> GetAllUsers(){
        return await _context.Users.ToListAsync();
    }

    //Create a user
    public async Task<User> CreateUser(User user){
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    //Get user by id
    public async Task<User?> GetUserById(int id){
        return await _context.Users.FindAsync(id);
    }

    //Authenticate user
    public async Task<User> GetUserByUsername(string username){

        User user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        if(user!= null){
            return user;
        }
        return null;
    }

    //Update user password
    public async Task<User> UpdateUser(User user){
       User selectedUser = await _context.Users.FindAsync(user.UserId);

       selectedUser.Username = user.Username;
       selectedUser.Password =  user.Password;
       selectedUser.RoleId = user.RoleId;

        _context.Users.Update(selectedUser);
        await _context.SaveChangesAsync();

       return selectedUser;
    }

    //Delete user
    public async Task Delete(User selectedUser)
    {
        _context.Users.Remove(selectedUser);
        await _context.SaveChangesAsync();
    }
}