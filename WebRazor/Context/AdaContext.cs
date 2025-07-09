using Microsoft.EntityFrameworkCore;
using WebRazor.Model;

namespace WebRazor.Context
{
  public class AdaContext : DbContext
  {

    
    public DbSet<Curso> Curso { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new CursoConfiguration());
      base.OnModelCreating(modelBuilder);
    }
  }
}