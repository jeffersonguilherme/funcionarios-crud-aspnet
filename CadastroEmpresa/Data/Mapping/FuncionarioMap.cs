using CadastroEmpresa.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroEmpresa.Data.Mapping{
    public class FuncionarioMap : IEntityTypeConfiguration<FuncionarioModel>
    {
        public void Configure(EntityTypeBuilder<FuncionarioModel> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd();
            
            builder.Property(x => x.Name)
                    .IsRequired()
                    .HasColumnName("Name")
                    .HasMaxLength(160);
            
            builder.Property(x => x.DataNascimento)
                    .IsRequired()
                    .HasColumnName("DataNascimento");

            builder.Property(x => x.Nacionalidade)
                    .IsRequired()
                    .HasColumnName("Nacionalidade")
                    .HasMaxLength(160);
            
            builder.Property(x => x.Naturalidade)
                    .HasColumnName("Naturalidade")
                    .HasMaxLength(160);
                
            builder.HasOne(x => x.DepartamentoModel)
                    .WithMany(x => x.FuncionarioModel)
                    .HasForeignKey(x =>x.DepartamentoId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}