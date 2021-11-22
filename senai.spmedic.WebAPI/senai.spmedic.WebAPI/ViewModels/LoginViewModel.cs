using System.ComponentModel.DataAnnotations;

namespace senai.spmedic.WebAPI.Controllers
{
    /// <summary>
    /// Classe responsável pelo modelo de login
    /// </summary>
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail do usuário!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário!")]
        public string Senha { get; set; }
    }
}