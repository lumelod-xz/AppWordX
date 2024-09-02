using System.ComponentModel.DataAnnotations;

namespace AppWordX.Models
{
    public class Documento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite um titulo")]
        public string Titulo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Digite um conteudo para o documento")]
        public string Conteudo { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
