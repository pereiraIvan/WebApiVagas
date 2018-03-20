using System.Data.Entity.ModelConfiguration;
using WebApiVagas.Models.Entities;

namespace WebApiVagas.Models.Mapping
{
    public class EmpresaMapping : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMapping()
        {
            ToTable("Empresas");

            HasKey(v => v.Id);

            Property(v => v.Nome).IsRequired().HasMaxLength(100);
        }
    }
}