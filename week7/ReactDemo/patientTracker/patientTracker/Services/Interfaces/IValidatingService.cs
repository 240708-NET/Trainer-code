public interface IValidatinService{

    /**
        Validate against regex and null checks
    */
    public bool isCorrectPassword(string password);
    bool isCorrectUsername(string username);
}