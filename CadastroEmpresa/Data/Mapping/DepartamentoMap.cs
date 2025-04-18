using CadastroEmpresa.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroEmpresa.Data.Mapping{
    public class DepartamentoMap : IEntityTypeConfiguration<DepartamentoModel>
    {
        public void Configure(EntityTypeBuilder<DepartamentoModel> builder)
        {
            builder.ToTable("Departamento");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd();
            
            builder.Property(x => x.Name)
                    .IsRequired()
                    .HasColumnName("Name")
                    .HasMaxLength(160);
        }
    }
}