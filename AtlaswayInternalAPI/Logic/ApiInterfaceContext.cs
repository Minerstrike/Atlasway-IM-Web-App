using AtlaswayInternalAPI.Models;
using AtlaswayInternalAPI.SQLBusinessLogic.BussinessLogic;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;

namespace AtlaswayInternalAPI.Logic;


internal sealed class ApiInterfaceContext
{
    #region Properties

    private AtlaswayInternalDbContext dbContext { get; }

    #endregion

    #region Constructor

    internal ApiInterfaceContext(AtlaswayInternalDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    #endregion

    #region Methods

    internal IEnumerable<Client_Json> GetClients()
    {
        ClientsActionsContext clientsContext = new ClientsActionsContext(dbContext);

        return clientsContext
            .GetClients()
            .Select(x => new Client_Json(x));
    }

    internal IEnumerable<Project_Json> GetProjects()
    {
        ProjectsActionsContext projectsContext = new ProjectsActionsContext(dbContext);

        return projectsContext
            .GetProjects()
            .Select(x => new Project_Json(x));
    }

    internal void PostProject(NewProject_Json project_Json)
    {
        ProjectsActionsContext projectsContext = new ProjectsActionsContext(dbContext);

        Project project = new Project(
            projectName : project_Json.ProjectName,
            clientNo    : project_Json.ClientNo,
            statusNo    : project_Json.StatusNo);

        projectsContext.PostProject(project);
    }

    //internal IEnumerable<Project_JsonV2> GetProjectsV2()
    //{
    //    ProjectsActionsContext projectsContext = new ProjectsActionsContext(dbContext);

    //    return projectsContext
    //        .GetProjectsV2()
    //        .Select(x => new Project_JsonV2(x));
    //}

    internal IEnumerable<ProjectStatusType_Json> GetProjectStatusTypes()
    {
        ProjectsActionsContext projectsContext = new ProjectsActionsContext(dbContext);

        return projectsContext
            .GetProjectStatusTypes()
            .Select(x => new ProjectStatusType_Json(x));
    }

    internal IEnumerable<Staff_Json> GetStaff()
    {
        StaffActionsContext staffContext = new StaffActionsContext(dbContext);

        return staffContext
            .GetStaff()
            .Select(x => new Staff_Json(x));
    }

    #endregion
}
