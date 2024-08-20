using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace patientTracker.Models;

public class Doctor{

    [Key]
    public int UserId  {get;set;}

    [Required]
    public string fullName{get;set;}
    [Required]

    public string specialization{get;set;}
    public string education{get;set;}

    public string phoneNumber{get;set;}

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime hireDate {get;set;} = DateTime.UtcNow;

    public ICollection<Patient> Patients {get;set;}

    [ForeignKey("UserId")]
    public User Users {get;set;}


}

