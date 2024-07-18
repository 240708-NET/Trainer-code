using System.ComponentModel.DataAnnotations;
namespace migrationDemo.Models;

public class Employees{

    [Key] // it indicates that EmployeeID is a primary key
    public int EmployeeID { get; set; }

    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}