using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mf_Dev_BackEnd.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar um nome!")]
        [Display(Name = "Nome do veículo")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatório informar uma placa!")]
        [Display(Name = "Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano de fabricação!")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano do modelo!")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a cor do carro!")]
        [Display(Name = "Cor do veículo")]
        public string Cor { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
