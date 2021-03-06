using IkeMtz.NRSRx.Core.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace IkeMtz.NRSRx.Core.Tests
{
  public class TestAuditableDbContext : AuditableDbContext
  {
    public TestAuditableDbContext(DbContextOptions options, IHttpContextAccessor httpContextAccessor) : base(options, httpContextAccessor)
    {
    }
    public DbSet<MyModel> MyModel { get; set; }
    public DbSet<CollectionModel> CollectionModel { get; set; }
  }

  public class TestDbContext : DbContext
  {
    public TestDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<MyModel> MyModel { get; set; }
    public DbSet<CollectionModel> CollectionModel { get; set; }
  }
}
