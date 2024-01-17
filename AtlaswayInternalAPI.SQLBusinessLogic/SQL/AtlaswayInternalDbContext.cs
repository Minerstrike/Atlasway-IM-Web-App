using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AtlaswayInternalAPI.SQLBusinessLogic.SQL;


public class AtlaswayInternalDbContext : DbContext
{
    #region Constructor

    public AtlaswayInternalDbContext() : base() { }

    public AtlaswayInternalDbContext(DbContextOptions<AtlaswayInternalDbContext> options) : base(options) { }

    #endregion

    #region Tables

    internal DbSet<Client>              Clients             { get; private init; }
    internal DbSet<Project>             Projects            { get; set; }
    //internal DbSet<ProjectV2>           ProjectsV2          { get; private init; }
    internal DbSet<ProjectStatusType>   ProjectStatusTypes  { get; private init; }
    internal DbSet<Staff>               Staff               { get; private init; }

    #endregion
}
