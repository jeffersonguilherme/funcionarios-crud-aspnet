namespace CadastroEmpresa.Model{
    public class DepartamentoModel{
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<FuncionarioModel> Funcionarios { get; set; } = new List<FuncionarioModel>();


    }
}