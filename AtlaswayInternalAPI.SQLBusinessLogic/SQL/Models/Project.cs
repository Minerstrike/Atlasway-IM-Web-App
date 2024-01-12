using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;


[Table("projects")]
public class Project
{
    [Key]
    [Column("projectno")]   public uint     ProjectNo   { get; private init; }
    [Column("projectname")] public string   ProjectName { get; private init; }
    [Column("clientno")]    public uint     ClientNo    { get; private init; }
    [Column("statusno")]    public uint     StatusNo    { get; private init; }

    public Project(uint projectNo, string projectName, uint clientNo, uint statusNo)
    {
        ProjectNo   = projectNo;
        ProjectName = projectName;
        ClientNo    = clientNo;
        StatusNo    = statusNo;
    }   
}
