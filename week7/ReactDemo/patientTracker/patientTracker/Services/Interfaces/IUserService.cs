using patientTracker.DTO;
using patientTracker.Models;
namespace patientTracker.Services;

public interface IUserService{

    Task<string> Authenticate(UserAuthenticationDTO user);
    Task<UserDTO> CreateUser(CreateUserDTO userDTO);
    Task<bool> Delete(int userId);
    Task<IEnumerable<UserDTO>> GetAll();
    Task<UserDTO> UpdateUserPassword(int userId, string newPassword);
}