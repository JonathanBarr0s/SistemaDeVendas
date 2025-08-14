using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models
{
	public class LoginModel
	{
        [Required(ErrorMessage ="Informe o e-mail.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O e-mail informado é inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Informe a senha.")]
        public string Senha { get; set; }
    }
}
