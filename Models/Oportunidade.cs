using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;

namespace GerenciamentoDeVendas.Models
{
    public class Oportunidade
    {
        [Key]
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public int ValorMonetario { get; set; }
        [JsonIgnore]
        public Usuario Usuarios { get; set; }

        public async Task<CNPJ> InformacoesAdicionais()
        {
            var clientHttp = new HttpClient { BaseAddress = new Uri("https://publica.cnpj.ws") };
            var response = await clientHttp.GetAsync($"cnpj/{Cnpj}");

            var resp = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CNPJ>(resp);

        }


    }

    }

