using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebRazor.Model;

namespace WebRazor.Context
{
  public class CursoConfiguration : IEntityTypeConfiguration<Curso>
  {
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
      builder.ToTable("Curso");

      builder.HasKey(x => x.Id);
      builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(100)");
    }
  }
}