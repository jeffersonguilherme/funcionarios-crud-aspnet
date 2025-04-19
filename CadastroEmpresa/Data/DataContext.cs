using CadastroEmpresa.Data.Mapping;
using CadastroEmpresa.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroEmpresa.Data{
    public class DataContext : DbContext{
        public DbSet<DocumentoModel> DocumentoModels { get; set; }
        public DbSet<FuncionarioModel> FuncionarioModels { get; set; }
        public DbSet<DepartamentoModel> DepartamentoModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=CadastroFuncionario;User ID=sa;Password=Xy23h2o1@Sql;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DocumentoMap());
            builder.ApplyConfiguration(new FuncionarioMap());
            builder.ApplyConfiguration(new DepartamentoMap());
        }
    }
}
