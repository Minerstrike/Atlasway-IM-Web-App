using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;


[Table("staff")]
public class Staff
{
    [Key]
    [Column("staffno")]         public uint     StaffNo         { get; private init; }
    [Column("surname")]         public string   Surname         { get; private init; }
    [Column("firstname")]       public string   Firstname       { get; private init; }
    [Column("contactno")]       public string?  ContactNo       { get; private init; }
    [Column("emailaddress")]    public string?  EmailAddress    { get; private init; }

    public Staff(uint staffNo, string surname, string firstname, string? contactNo, string? emailAddress)
    {
        StaffNo         = staffNo;
        Surname         = surname;  
        Firstname       = firstname;
        ContactNo       = contactNo;
        EmailAddress    = emailAddress;
    }

    public Staff(string surname, string firstname, string? contactNo, string? emailAddress)
    {
        Surname         = surname;  
        Firstname       = firstname;
        ContactNo       = contactNo;
        EmailAddress    = emailAddress;
    }
}
