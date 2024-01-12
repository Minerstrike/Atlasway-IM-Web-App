using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using System.Text.Json.Serialization;

namespace AtlaswayInternalAPI.Models;


public struct Staff_Json
{
    [JsonPropertyName("staffNo")]       public uint     StaffNo         { get; init; }
    [JsonPropertyName("surname")]       public string   Surname         { get; init; }
    [JsonPropertyName("firstname")]     public string   Firstname       { get; init; }
    [JsonPropertyName("contactNo")]     public string   ContactNo       { get; init; }
    [JsonPropertyName("emailaddress")]  public string   EmailAddress    { get; init; }

    internal Staff_Json(Staff staff)
    {
        StaffNo         = staff.StaffNo;
        Surname         = staff.Surname;
        Firstname       = staff.Firstname;
        ContactNo       = staff.ContactNo;
        EmailAddress    = staff.EmailAddress;
    }
}
