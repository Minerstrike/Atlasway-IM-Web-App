using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;


[Table("projectstatustypes")]
public class ProjectStatusType
{
    [Key]
    [Column("typeno")]      public uint     TypeNo      { get; private init; }
    [Column("typename")]    public string   TypeName    { get; private init; }

    public ProjectStatusType(uint typeNo, string typeName)
    {
        TypeNo      = typeNo;
        TypeName    = typeName;
    }
}
