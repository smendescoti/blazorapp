using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Web.Requests
{
    public class EditarEstoquesRequest
    {
        public string? Id { get; set; }

        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do estoque.")]
        public string? Nome { get; set; }
              
        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(250, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a descrição do estoque.")]
        public string? Descricao { get; set; }
    }
}
