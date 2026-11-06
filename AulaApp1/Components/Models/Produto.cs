
using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Informe o nome do produto.")]
        public string Nome { get; set; } = "";

        [Range(0.01, double.MaxValue,
            ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }

        public int Quantidade { get; set; }
    }
}
