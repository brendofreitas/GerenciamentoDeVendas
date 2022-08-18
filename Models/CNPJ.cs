using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace GerenciamentoDeVendas.Models
{
    public class CNPJ
    {

        [Key]
        public int Id { get; set; }
        [JsonProperty("cnpj_raiz")]
        public string CnpjRaiz { get; set; }
        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }
        public Estabelecimento Estabelecimento { get; set; }



    }
}

