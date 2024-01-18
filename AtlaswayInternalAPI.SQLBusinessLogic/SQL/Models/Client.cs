using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;


[Table("clients")]
public class Client
{
    [Key]
    [Column("clientno")]        public int      ClientNo        { get; private init; }
    [Column("clientname")]      public string   ClientName      { get; private init; }
    [Column("contactno")]       public string?  ContactNo       { get; private init; }
    [Column("emailaddress")]    public string?  EmailAddress    { get; private init; }

    public Client(int clientNo, string clientName, string? contactNo, string? emailAddress)
    {
        ClientNo       = clientNo;
        ClientName     = clientName;
        ContactNo      = contactNo;
        EmailAddress   = emailAddress;
    }

    public Client(string clientName, string? contactNo, string? emailAddress)
    {
        ClientName     = clientName;
        ContactNo      = contactNo;
        EmailAddress   = emailAddress;
    }
}
