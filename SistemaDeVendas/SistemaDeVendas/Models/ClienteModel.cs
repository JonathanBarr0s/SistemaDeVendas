namespace SistemaDeVendas.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
