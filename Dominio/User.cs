using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = " * Obrigatório")]
        [DisplayName("Digite o Nome:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = " * Obrigatório")]
        [DisplayName("Digite o CPF:")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = " * Obrigatório")]
        [DisplayName("Digite o Telefone:")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = " * Obrigatório")]
        [DisplayName("Digite o Sexo:")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = " * Obrigatório")]
        [DisplayName("Digite a CNH:")]
        public bool Cnh { get; set; }
    }
}