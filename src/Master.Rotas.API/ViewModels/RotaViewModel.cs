using System.ComponentModel.DataAnnotations;

namespace Master.Rotas.API.ViewModels
{
    public class RotaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {3} e {1} caracteres", MinimumLength = 3)]
        public string Origem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {3} e {1} caracteres", MinimumLength = 3)]
        public string Destino { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
