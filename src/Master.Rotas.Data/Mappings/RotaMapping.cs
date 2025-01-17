using Master.Rotas.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Master.Rotas.Data.Mappings
{
    public class RotaMapping : IEntityTypeConfiguration<Rota>
    {
        public void Configure(EntityTypeBuilder<Rota> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Origem)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Destino)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Rotas");
        }
    }
}
