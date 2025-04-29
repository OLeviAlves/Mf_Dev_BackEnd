using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mf_Dev_BackEnd.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        [Display(Name = "Veículo")]
        public Veiculo Veiculo { get; set; }
    }
    public enum TipoCombustivel 
    {
        Gasolina,
        GasolinaAditivada,
        Etanol,
        Gas
    }
}
