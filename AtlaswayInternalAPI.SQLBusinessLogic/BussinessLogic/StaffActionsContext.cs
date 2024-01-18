using AtlaswayInternalAPI.SQLBusinessLogic.BussinessLogic.Base;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using Microsoft.EntityFrameworkCore;

namespace AtlaswayInternalAPI.SQLBusinessLogic.BussinessLogic;

public sealed class StaffActionsContext : BaseActionsContext<AtlaswayInternalDbContext>
{
    #region Constructor

    public StaffActionsContext(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

    #endregion

    #region Methods

    public IQueryable<Staff> GetStaff()
    {
        return dbContext.Staff;
    }

    public void PostStaff(Staff staff)
    {
        dbContext.Staff.Add(staff);

        dbContext.SaveChanges();
    }

    public void PutStaff(Staff staff)
    {
        dbContext.Staff.Update(staff);

        dbContext.SaveChanges();
    }

    #endregion
}
