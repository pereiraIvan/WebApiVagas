using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApiVagas.Models.Entities
{
    public class Empresa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [JsonIgnore]
        public virtual ICollection<Vaga> Vagas { get; set; }
    }
}