using gs_server.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gs_server.EntityConfigurations;

public class TuitionConfiguration : IEntityTypeConfiguration<Tuition>
{
  public void Configure(EntityTypeBuilder<Tuition> typeBuilder)
  {

  }
}