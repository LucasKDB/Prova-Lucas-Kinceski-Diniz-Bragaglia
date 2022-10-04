using System;
using System.ComponentModel.DataAnnotations;


namespace API.Models
{
    //Data Annotations
    public class Funcionario
    {
        public Funcionario () => CriadoEm = DateTime.Now;
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }

        
        [Required(ErrorMessage = "O campo CPF é obrigatório!")]

        // [CpfEmUso]
        public string Cpf { get; set; }

        [EmailAddress(
            ErrorMessage = "E-mail inválido!"
        )]
        public string Email { get; set; }

        public DateTime Nascimento { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}