using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static GerenciamentoDeVendas.Models.Usuario;

namespace GerenciamentoDeVendas.Data.Dto.UsuarioDto
{
    public class CreateUsuarioDto
    {
       
        [Required(ErrorMessage = "Campo nome e obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo E-mail e obrigatorio")]
        [Key]
        public string Email { get; set; }
        public Regiao RegiaoResponsavel { get; set; }
    }
}
