using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploValidacao.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Nome é obrigatorio")]
        public string Nome { get; set; }

        [StringLength(50,MinimumLength = 5, ErrorMessage = "A Observação deve ter entre 5 a 50 caracteres")]
        public string Observacao { get; set; }

        //[RegularExpression(@)]
        public string Email { get; set; }

        [Range(18, 50, ErrorMessage = "A idade da pessoa deve ser entre 18 e 50 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "A senha deve ser informada")] 
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "A senha não confere")]
        public string ConfirmarSenha { get; set; }

        [RegularExpression(@"[a-zA-Z](5,15)", ErrorMessage = "Login deve ter entre 5 a 15 caracteres")]
        public string Login { get; set; }
    }
}