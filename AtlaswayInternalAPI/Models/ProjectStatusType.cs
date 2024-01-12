using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using System.Text.Json.Serialization;

namespace AtlaswayInternalAPI.Models;


public struct ProjectStatusType_Json
{
    [JsonPropertyName("typeNo")]    public uint     TypeNo      { get; init; }
    [JsonPropertyName("typeName")]  public string   TypeName    { get; init; }

    internal ProjectStatusType_Json(ProjectStatusType projectStatusType)
    {
        TypeNo      = projectStatusType.TypeNo;
        TypeName    = projectStatusType.TypeName;
    }
}
