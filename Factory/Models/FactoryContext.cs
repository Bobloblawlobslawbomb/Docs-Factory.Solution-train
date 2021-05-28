using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public virtual DbSet<Engineer> Engineers { get; set; } //dunno if we need the virtual
    public virtual DbSet<Machine> Machines { get; set; } //dunno if we need the virtual 
    public DbSet<EngineerMachine> EngineerMachines { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

  }
}