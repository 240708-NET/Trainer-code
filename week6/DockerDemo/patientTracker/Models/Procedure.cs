using System.ComponentModel.DataAnnotations;

namespace patientTracker.Models;

public class Procedure{

    [Key]
    public  string ProcedureCode  {get;set;}

    [Required(ErrorMessage = "Procedure's name is required")]
    public string? ProcedureName  {get;set;}
    public string? ProcedureDescription  {get;set;}


}