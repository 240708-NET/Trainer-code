
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using patientTracker.DTO;
using patientTracker.Models;
using patientTracker.Services;


[ApiController]
[Route("api/[controller]")]
public class UserController : Controller{

    public IUserService _userService;

    public UserController(IUserService userService){
        _userService = userService;
    }
    /*
        GET ALL USERS
    */
    [HttpGet]
    [Route("ListAllUsers")]
    public async Task<IActionResult>  GetAllUsers(){
        IEnumerable<UserDTO> allUsers =  await _userService.GetAll();
        return Ok(allUsers);
    }

    /*
        CREATE A USER
    */
    [HttpPost]
    [Route("CreateUser")]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO createdUserDTO){
        UserDTO user = await _userService.CreateUser(createdUserDTO);
        return Ok("Created User: " + user.Username);
    }

    /*
        UPDATE USER PASSWORD
    */
    [HttpPatch]
    [Route("UpdatePassword/{userId}")]
    public async Task<IActionResult> UpdateUserPassword(int userId, [FromBody]string newPassword){

        try{
              UserDTO user = await _userService.UpdateUserPassword(userId, newPassword);
            if(user != null){
                return Ok("Password updated for: " + user.Username);
            }
            else{
                return NotFound("User does not exist");
            }
        }
        catch(Exception ex){
            return BadRequest(ex.Message);
        }
      
    }


    /*
        DELETE USER
    */
    [HttpDelete]
    [Route("Delete/{userId}")]
    public async Task<IActionResult> DeleteUser(int userId){
        try{
            bool isDeleted = await _userService.Delete(userId);
            return Ok("User deleted");
        }
        catch(Exception ex){
            return BadRequest(ex.Message);
        }
    }

    /*AUTHENTICATION AND AUTHROZATION*/
    [HttpPost]
    [Route("AuthenticateUser")]
    public async Task<IActionResult> AuthenticateUser([FromBody] UserAuthenticationDTO user){
        try{

            //Return a JWT toket
            var authUser = await _userService.Authenticate(user);
            if(authUser == null){
                return Unauthorized();
            }
            else{
                Response.Cookies.Append("token", authUser, new CookieOptions{HttpOnly = true});
                return Ok("Success");
            }
        }
        catch(Exception ex){
            return BadRequest(ex.Message);
        }
    }

}