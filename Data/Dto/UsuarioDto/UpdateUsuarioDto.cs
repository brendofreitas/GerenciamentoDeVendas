using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static GerenciamentoDeVendas.Models.Usuario;

namespace GerenciamentoDeVendas.Data.Dto.UsuarioDto
{
    public class UpdateUsuarioDto
    {
        [Required(ErrorMessage ="O campo nome e obrigatorio")]
        public string Nome { get; set; }

        public Regiao RegiaoResponsavel { get; set; }
    }
}
