using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do contato deve ser informado.!")]
        [StringLength(50, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone deve ser informado.!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do telefone no formato (00) 0000-00000")]
        [DisplayName("Número do Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Ínforme a descrição do projeto.")]
        [DisplayName("Descrição do Projeto")]
        [StringLength(5000, MinimumLength = 20)]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
    }
}