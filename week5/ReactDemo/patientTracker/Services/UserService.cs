
using patientTracker.Models;
using patientTracker.Data.Repositories;
using patientTracker.DTO;

namespace patientTracker.Services;

public class UserService : IUserService
{
    public IUserRepo _userRepo;
    public IHashingService _hashingService;

    public IValidatinService _validationService;

    public JWTService _JWTService;

    public UserService(IUserRepo userRepo, IHashingService hashingService, IValidatinService validationService, JWTService jwtService)
    {
        _userRepo = userRepo;
        _hashingService = hashingService;
        _validationService = validationService;
        _JWTService = jwtService;
    }

    // Authenticate User
    public async Task<string> Authenticate(UserAuthenticationDTO user)
    {   

        //Check against the database
        User userData = await _userRepo.GetUserByUsername(user.Username);
        if(userData!= null){
            if(_hashingService.VerifyHashedPassword(userData.Password, user.Password)){
                    //Create a token
                string token = _JWTService.generateToken(userData);
                return token;
            }
        
            throw new Exception("Invalid password");
        }
        else{
           throw new Exception("User does not exist");
        }
    }

    //Create User
     public async Task<UserDTO> CreateUser(CreateUserDTO userDTO){
        //IMPLEMENT VALIDAION HERE
        if(_validationService.isCorrectPassword(userDTO.Password) && _validationService.isCorrectUsername(userDTO.Username))
        {
             var user = new User{
            Username = userDTO.Username,
            Password =  _hashingService.HashPassword(userDTO.Password),
            RoleId = userDTO.RoleId,
             DateCreated = DateTime.UtcNow
        };
        User newUser = await _userRepo.CreateUser(user);
    
        return new UserDTO{
            Username = newUser.Username,
            RoleId = newUser.RoleId
        }; 
        }
        else{
            return null;
        }
       
     }

    //List all users

    public async Task<IEnumerable<UserDTO>> GetAll()
    {   
        IEnumerable<User> users = await _userRepo.GetAllUsers();
        return users.Select(u => new UserDTO{
            Username = u.Username,
            RoleId = u.RoleId
        });
    }

    //Update User Password
    public async Task<UserDTO> UpdateUserPassword(int userId, string newPassword){

        //Get user by id
        User selectedUser = await _userRepo.GetUserById(userId);

        if(selectedUser!= null && _validationService.isCorrectPassword(newPassword)){
             string hashed_psw = _hashingService.HashPassword(newPassword);
             selectedUser.Password =  hashed_psw;
             await _userRepo.UpdateUser(selectedUser);

              return new UserDTO{
                Username = selectedUser.Username,
                RoleId = selectedUser.RoleId
            };
        }
        else{
            throw new Exception("User does not exist or new password is not valid");
        }

    }

    public async Task<bool> Delete(int userId){

        //Get by Id
        User selectedUser = await _userRepo.GetUserById(userId);
        if(selectedUser != null)
        {
            await _userRepo.Delete(selectedUser);
            return true;
        }
        else{
            throw new Exception("User does not exist");
        }
    }

    
}