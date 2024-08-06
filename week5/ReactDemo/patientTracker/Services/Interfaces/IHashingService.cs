
//For hashing passwords
public interface IHashingService{

    public string HashPassword(string password);
    bool VerifyHashedPassword(string password1, string password2);
}