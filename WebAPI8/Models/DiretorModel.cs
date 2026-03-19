using System.Text.Json.Serialization;

namespace WebAPI8.Models
{
    public class DiretorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore]
        public ICollection<FilmeModel> Filmes { get; set; }
    }
}
