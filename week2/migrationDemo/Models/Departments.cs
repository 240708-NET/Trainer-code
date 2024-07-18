namespace migrationDemo.Models;
using System.ComponentModel.DataAnnotations;


public class Departments{

    [Key] // it indicates that EmployeeID is a primary key
    public int DepartmentID { get; set; }
    public string DepartmentName { get; set; }
    public string DepartmentResponsibilites { get; set; }
}