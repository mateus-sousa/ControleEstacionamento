using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoControlado.Dominio.Entidades
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " Nome requerido.")]
        [Display(Name = "Nome:")]
        public string NomePessoa { get; set; }

        [Required(ErrorMessage = " CPF requerido.")]
        [Display(Name = "CPF:")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = " RG requerido.")]
        [Display(Name = "RG:")]
        public string Rg { get; set; }

        [Required(ErrorMessage = " E-mail requerido.")]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        public virtual ICollection<Veiculo> Veiculo { get; set; } 
   


    }
}
