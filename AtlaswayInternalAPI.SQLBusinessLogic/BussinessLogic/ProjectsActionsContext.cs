using AtlaswayInternalAPI.SQLBusinessLogic.BussinessLogic.Base;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using System;

namespace AtlaswayInternalAPI.SQLBusinessLogic.BussinessLogic;


public sealed class ProjectsActionsContext : BaseActionsContext<AtlaswayInternalDbContext>
{
    #region Constructor

    public ProjectsActionsContext(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

    #endregion

    #region Methods

    public IQueryable<Project> GetProjects()
    {
        return dbContext.Projects;
    }

    public IQueryable<ProjectStatusType> GetProjectStatusTypes()
    {
        return dbContext.ProjectStatusTypes;
    }

    #endregion
}
