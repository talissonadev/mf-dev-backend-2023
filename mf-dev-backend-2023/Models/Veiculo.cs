using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir o nome do veículo")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir a placa do veículo")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir o Ano de Fabricação")]
        public int AnoFabricacao { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir o Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}
