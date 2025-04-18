using CadastroEmpresa.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroEmpresa.Data.Mapping{
    public class DocumentoMap : IEntityTypeConfiguration<DocumentoModel>
    {
        public void Configure(EntityTypeBuilder<DocumentoModel> builder)
        {
            builder.ToTable("Documento");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(x => x.CarteiraTrabalho)
                    .IsRequired()
                    .HasColumnName("CTPS")
                    .HasMaxLength(12);
            
            builder.Property(x => x.Cpf)
                    .IsRequired()
                    .HasColumnName("Cpf")
                    .HasMaxLength(14);
            
            builder.Property(x => x.NumeroRg)
                    .IsRequired()
                    .HasColumnName("NumeroRg")
                    .HasMaxLength(20);

            builder.Property(x => x.PisPasep)
                    .IsRequired()
                    .HasColumnName("PisPasep")
                    .HasMaxLength(14);

            builder.Property(x => x.TituloEleitor)
                    .IsRequired()
                    .HasColumnName("TituloEleitor")
                    .HasMaxLength(12);

            builder.HasOne(x => x.FuncionarioModel)
                    .WithOne(x => x.DocumentoModel)
                    .HasForeignKey<DocumentoModel>(x => x.FuncionarioId)
                    .OnDelete(DeleteBehavior.Cascade);
            
        }
    }
}