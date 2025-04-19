namespace CadastroEmpresa.Model{
    public class FuncionarioModel{
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public int DocumentoId { get; set; }
        public DocumentoModel DocumentoModel { get; set; }
        public int DepartamentoId { get; set; }
        public virtual DepartamentoModel DepartamentoModel { get; set; }
    }
}