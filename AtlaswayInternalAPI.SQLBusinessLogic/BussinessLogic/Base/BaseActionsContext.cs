using Microsoft.EntityFrameworkCore;

namespace AtlaswayInternalAPI.SQLBusinessLogic.BussinessLogic.Base;


public abstract class BaseActionsContext<TDbContext> where TDbContext : DbContext
{
    protected TDbContext dbContext { get; }

    protected BaseActionsContext(TDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public int SaveChanges()
    {
        return dbContext.SaveChanges();
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        return await dbContext.SaveChangesAsync(cancellationToken);
    }
}
