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

    internal void PostClient(NewClient_Json client_Json)
    {
        ClientsActionsContext clientsContext = new ClientsActionsContext(dbContext);

        Client client = new Client(
            clientName      : client_Json.ClientName,
            contactNo       : client_Json.ContactNo,
            emailAddress    : client_Json.EmailAddress);

        clientsContext.PostClient(client);
    }

    internal void UpdateClient(Client_Json client_Json)
    {
        ClientsActionsContext clientsContext = new ClientsActionsContext(dbContext);

        Client client = new Client(
            clientNo        : client_Json.ClientNo,
            clientName      : client_Json.ClientName,
            contactNo       : client_Json.ContactNo,
            emailAddress    : client_Json.EmailAddress);

        clientsContext.UpdateClient(client);
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

    internal void PutProject(Project_Json project_Json)
    {
        ProjectsActionsContext projectsContext = new ProjectsActionsContext(dbContext);

        Project project = new Project(
            projectNo   : project_Json.ProjectNo,
            projectName : project_Json.ProjectName,
            clientNo    : project_Json.ClientNo,
            statusNo    : project_Json.StatusNo);

        projectsContext.PutProject(project);
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

    internal void PostStaff(NewStaff_Json staff_json)
    {
        StaffActionsContext staffContext = new StaffActionsContext(dbContext);

        Staff staff = new Staff(
            surname         : staff_json.Surname,
            firstname       : staff_json.Firstname,
            contactNo       : staff_json.ContactNo,
            emailAddress    : staff_json.EmailAddress);

        staffContext.PostStaff(staff);
    }

    internal void PutStaff(Staff_Json staff_json)
    {
        StaffActionsContext staffContext = new StaffActionsContext(dbContext);

        Staff staff = new Staff(
            staffNo         : staff_json.StaffNo,
            surname         : staff_json.Surname,
            firstname       : staff_json.Firstname,
            contactNo       : staff_json.ContactNo,
            emailAddress    : staff_json.EmailAddress);

        staffContext.PutStaff(staff);
    }

    #endregion
}
