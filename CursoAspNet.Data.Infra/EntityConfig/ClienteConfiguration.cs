using CursoAspNet.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CursoAspNet.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(p => p.ClienteId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Sobrenome)
               .IsRequired()
               .HasMaxLength(150);

            Property(p => p.Email)
               .IsRequired();
        }
    }
}