using System.ComponentModel.DataAnnotations;

namespace ApiAutenticacaoUsuario.Dto.Usuario
{
    public class UsuarioCriacaoDto
    {
        [Required(ErrorMessage = "Digite o Usuário")]
        public string Usuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o Nome")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o Sobrenome")]
        public string Sobrenome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o E-mail")]
        public string Email { get; set; } = string.Empty;

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime DataAteracao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Digite a Senha")]
        public string Senha { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite a Confrmação de Senha"), 
            Compare("Senha", ErrorMessage = "A Senhas não são iguais!")]
        public string ConfirmaSenha { get; set; } = string.Empty;
    }
}
