using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using System.Text.Json.Serialization;

namespace AtlaswayInternalAPI.Models;


public struct Project_Json
{
    [JsonPropertyName("projectNo")]     public uint     ProjectNo   { get; set; }
    [JsonPropertyName("projectName")]   public string   ProjectName { get; set; }
    [JsonPropertyName("clientno")]      public uint     ClientNo    { get; set; }
    [JsonPropertyName("statusno")]      public uint     StatusNo    { get; set; }

    internal Project_Json(Project project)
    {
        ProjectNo   = project.ProjectNo;
        ProjectName = project.ProjectName;
        ClientNo    = project.ClientNo;
        StatusNo    = project.StatusNo;
    }
}

public struct NewProject_Json
{
    [JsonPropertyName("projectName")]   public string?  ProjectName { get; set; }
    [JsonPropertyName("clientno")]      public uint     ClientNo    { get; set; }
    [JsonPropertyName("statusno")]      public uint     StatusNo    { get; set; }

    internal NewProject_Json(string? projectName, uint clientNo, uint statusNo)
    {
        this.ProjectName = projectName;
        this.ClientNo    = clientNo;
        this.StatusNo    = statusNo;
    }
}

//public struct Project_JsonV2
//{
//    [JsonPropertyName("projectNo")]     public uint             ProjectNo   { get; init; }
//    [JsonPropertyName("projectName")]   public string?          ProjectName { get; init; }
//    [JsonPropertyName("clientno")]      public uint             ClientNo    { get; init; }
//    [JsonPropertyName("status")]        public ProjectStatus    Status      { get; init; }

//    internal Project_JsonV2(ProjectV2 project)
//    {
//        ProjectNo   = project.ProjectNo;
//        ProjectName = project.ProjectName;
//        ClientNo    = project.ClientNo;
//        Status      = project.Status;
//    }
//}
