using System.Text.RegularExpressions;

public class ValidateService : IValidatinService{
    public bool isCorrectPassword(string password){
        string regex = @"^(?=.*[a-z])(?=.*[A-Z])";
        if(password.Length > 7 && Regex.IsMatch(password, regex)){
            return true;
        }
        else{
            return false;
        }
    }

    public bool isCorrectUsername(string username)
    {    string regex = @"[@!#$%^&*()_+|~=`{}\[\]:""<>?,./;'\\-]";
        if(username.Length > 2 && !Regex.IsMatch(username, regex)){
            return true;
        }
        return false;
    }
}