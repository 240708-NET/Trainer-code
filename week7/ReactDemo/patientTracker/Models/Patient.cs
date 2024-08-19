using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace patientTracker.Models;

public class Patient{

    [Key]
    public int UserId  {get;set;}

    [Required(ErrorMessage = "Patient's name is required")]
    public  string FullName {get;set;}
    public int? Age {get;set;}
    public string? Address {get;set;}
    public int? Height {get;set;}
    public int? Weight {get;set;}

    [Required]
    public int DoctorId { get; set; }

    [Required(ErrorMessage = "Patient's diagnosis is required")]
    public string Diagnosis {get;set;}
    [Required(ErrorMessage = "Patient's primary care doctor's is required")]
   

    [ForeignKey("UserId")]
    public Doctor? Doctors {get;set;}


    [ForeignKey("UserId")]
    public User Users {get;set;}

    

}