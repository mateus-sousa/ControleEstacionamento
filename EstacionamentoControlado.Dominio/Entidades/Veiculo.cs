using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoControlado.Dominio.Entidades
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " Marca do Veiculo é requerida.")]
        [Display(Name = "Marca do Veiculo:")]
        public string MarcaVeiculo { get; set; }

        [Required(ErrorMessage = " Modelo do Veiculo é requerido.")]
        [Display(Name = "Modelo do Veiculo:")]
        public string ModeloVeiculo { get; set; }

        [Required(ErrorMessage = " Placa do Veiculo é requerida.")]
        [Display(Name = "Placa:")]
        public string Placa { get; set; }

        [Required(ErrorMessage = " Ano de lançamento de veiculo é requerido.")]
        [Display(Name = "Ano de Lançamento:")]
        public DateTime AnoVeiculo { get; set; }
        
    }
}