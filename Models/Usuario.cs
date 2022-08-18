using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GerenciamentoDeVendas.Models
{
    public class Usuario
    {
        public enum Regiao
        {
            Norte,
            Nordeste,
            Sudeste,
            Sul,
            CentroOeste
        }
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo nome e obrigatorio")]
        public string Nome { get; set; }
        [Key]
        [Required(ErrorMessage ="Campo E-mail e obrigatorio")]
        public string Email { get; set; }
        [JsonIgnore]
        public Regiao RegiaoResponsavel { get; set; }
        [JsonIgnore]
        public List<Oportunidade> Oportunidades { get; set; }
    }
}
