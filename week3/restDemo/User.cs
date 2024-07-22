public class User{
    public int Id{ get; set; }
    public string Firstname{ get; set; }
    public string Lastname{ get; set; }

    public User(int id, string firstname, string lastname){
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
    }
}

