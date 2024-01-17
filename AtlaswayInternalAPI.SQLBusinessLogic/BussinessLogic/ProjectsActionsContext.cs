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

    public void PostProject(Project project)
    {
        dbContext.Projects.Add(project);

        dbContext.SaveChanges();
    }

    //public IQueryable<ProjectV2> GetProjectsV2()
    //{
    //    return dbContext.ProjectsV2;
    //}

    public IQueryable<ProjectStatusType> GetProjectStatusTypes()
    {
        return dbContext.ProjectStatusTypes;
    }

    #endregion
}
