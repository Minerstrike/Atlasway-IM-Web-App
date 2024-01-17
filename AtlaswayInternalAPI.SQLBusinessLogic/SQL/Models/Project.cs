using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;


[Table("projects")]
public class Project
{
    [Key]
    [Column("projectno")]   public uint     ProjectNo   { get; set; }
    [Column("projectname")] public string   ProjectName { get; set; }
    [Column("clientno")]    public uint     ClientNo    { get; set; }
    [Column("statusno")]    public uint     StatusNo    { get; set; }

    public Project(uint projectNo, string projectName, uint clientNo, uint statusNo)
    {
        ProjectNo   = projectNo;
        ProjectName = projectName;
        ClientNo    = clientNo;
        StatusNo    = statusNo;
    }

    public Project(string projectName, uint clientNo, uint statusNo)
    {
        ProjectName = projectName;
        ClientNo    = clientNo;
        StatusNo    = statusNo;
    }
}

//public interface IProject
//{
//    uint    ProjectNo   { get; set; }
//    string  ProjectName { get; set; }
//    uint    ClientNo    { get; set; }
//    uint    StatusNo    { get; set; }
//}

//[Table("projects")]
//public class ProjectV2
//{
//    [Key]
//    [Column("projectno")]       public uint             ProjectNo   { get; private init; }
//    [Column("projectname")]     public string           ProjectName { get; private init; }
//    [Column("clientno")]        public uint             ClientNo    { get; private init; }
//    [Column("status")]          public ProjectStatus    Status      { get; private init; }

//    public ProjectV2(uint projectNo, string projectName, uint clientNo, ProjectStatus status)
//    {
//        ProjectNo   = projectNo;
//        ProjectName = projectName;
//        ClientNo    = clientNo;
//        Status      = status;
//    }   
//}
