using CadastroEmpresa.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroEmpresa.Data{
    public class DataContext : DbContext{
        public DbSet<DocumentoModel> DocumentoModels { get; set; }
        public DbSet<FuncionarioModel> FuncionarioModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("DataSource=app.db;Cache=Shared");
        }
    }
}
