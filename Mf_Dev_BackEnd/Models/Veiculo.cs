using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mf_Dev_BackEnd.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; } 

        [Required(ErrorMessage ="Obrigatorio informar um nome!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar uma placa!")]
        public int Placa { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o ano de frabricação!")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o ano do modelo!")]
        public int AnoModelo { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a cor do carro!")]
        public string Cor { get; set; } 
    }
}
