using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace patientTracker.Models;

public class User{

[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int UserId {get;set;}
[Required(ErrorMessage ="Username is required")]
public string Username {get;set;}
[Required(ErrorMessage ="Password is required")]
public string Password {get;set;}

public int RoleId {get;set;}


[Required]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public DateTime DateCreated {get;set;} = DateTime.UtcNow;


}