using System.Data.Entity.ModelConfiguration;
using WebApiVagas.Models.Entities;

namespace WebApiVagas.Models.Mapping
{
    public class RequisitoMapping : EntityTypeConfiguration<Requisito>
    {
        public RequisitoMapping()
        {
            ToTable("Requisitos");

            HasKey(v => v.Id);

            Property(v => v.Descricao).IsRequired().HasMaxLength(100);

            HasRequired<Vaga>(r => r.Vaga).WithMany(v => v.Requisitos)
                                          .WillCascadeOnDelete();
        }
    }
}