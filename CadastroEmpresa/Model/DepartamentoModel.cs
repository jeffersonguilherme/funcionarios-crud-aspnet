namespace CadastroEmpresa.Model{
    public class DepartamentoModel{
        public int Id { get; set; }
        public List<FuncionarioModel> FuncionarioModel { get; set; }
        public string Name { get; set; }

    }
}