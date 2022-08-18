using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static GerenciamentoDeVendas.Models.Usuario;

namespace GerenciamentoDeVendas.Data.Dto.UsuarioDto
{
    public class ReadUsuarioDto
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo nome e obrigatorio")]
        public string Nome { get; set; }
        [Key]
        public string Email { get; set; }
        public Regiao RegiaoResponsavel { get; set; }
    }
}
