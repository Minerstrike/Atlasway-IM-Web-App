using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using System.Text.Json.Serialization;

namespace AtlaswayInternalAPI.Models;


public struct Project_Json
{
    [JsonPropertyName("projectNo")]     public uint     ProjectNo   { get; init; }
    [JsonPropertyName("projectName")]   public string?  ProjectName { get; init; }
    [JsonPropertyName("clientno")]      public uint     ClientNo    { get; init; }
    [JsonPropertyName("statusno")]      public uint     StatusNo    { get; init; }

    internal Project_Json(Project project)
    {
        ProjectNo   = project.ProjectNo;
        ProjectName = project.ProjectName;
        ClientNo    = project.ClientNo;
        StatusNo    = project.StatusNo;
    }
}
