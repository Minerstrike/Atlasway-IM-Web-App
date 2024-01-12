using AtlaswayInternalAPI.SQLBusinessLogic.BussinessLogic.Base;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using System;

namespace AtlaswayInternalAPI.SQLBusinessLogic.BussinessLogic;

public sealed class ClientsActionsContext : BaseActionsContext<AtlaswayInternalDbContext>
{
    #region Constructor

    public ClientsActionsContext(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

    #endregion

    #region Methods

    public IQueryable<Client> GetClients()
    {
        return dbContext.Clients;
    }

    #endregion
}
