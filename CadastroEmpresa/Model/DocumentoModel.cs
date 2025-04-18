namespace CadastroEmpresa.Model{
    public class DocumentoModel{
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public FuncionarioModel FuncionarioModel { get; set; }
        public string CarteiraTrabalho { get; set; }
        public string Cpf { get; set; }
        public string NumeroRg { get; set; }
        public string PisPasep { get; set; }
        public string TituloEleitor { get; set; }
    }
}