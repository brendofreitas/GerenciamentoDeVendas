using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeVendas.Models
{
    public class Estabelecimento
    {
        [Key]
        public string Id { get; set; }
        public virtual CNPJ Cnpj { get; set; }
        public string Estado { get; set; }
        [JsonProperty("atividade_principal")]
        public string AtividadePrincipal { get; set; }
    }
}
