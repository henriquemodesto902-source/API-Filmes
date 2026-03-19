using System.Text.Json.Serialization;

namespace WebAPI8.Models
{
    public class FilmeModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public double Nota { get; set; }
        public string Genero { get; set; }
        public DiretorModel Diretor { get; set; }



       
    }
}
