using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using System.Text.Json.Serialization;

namespace AtlaswayInternalAPI.Models;


public struct Client_Json
{
    [JsonPropertyName("clientNo")]      public int      ClientNo        { get; init; }
    [JsonPropertyName("clientName")]    public string   ClientName      { get; init; }
    [JsonPropertyName("contactNo")]     public string?  ContactNo       { get; init; }
    [JsonPropertyName("emailAddress")]  public string?  EmailAddress    { get; init; }

    internal Client_Json(Client client)
    {
        ClientNo        = client.ClientNo;
        ClientName      = client.ClientName;
        ContactNo       = client.ContactNo;
        EmailAddress    = client.EmailAddress;
    }
}
