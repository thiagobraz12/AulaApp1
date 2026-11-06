
using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "Informe o nome da categoria.")]
        [MinLength(3, ErrorMessage = "O nome deve possuir pelo menos 3 caracteres.")]
        public string Nome { get; set; } = "";

        [Range(0, 100000,
            ErrorMessage = "A quantidade deve estar entre 0 e 100000.")]
        public int Quantidade { get; set; }
    }
}
