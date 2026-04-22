using Api_Filmes.Models;

namespace Api_Filmes.Services.Diretor
{
    public interface DiretorInterface
    {
        Task<ResponseModel<List<DiretorModel>>> ListarDiretores();
        Task<ResponseModel<DiretorModel>> BuscarDiretorPorId(int idDiretor);
        Task<ResponseModel<DiretorModel>> BuscarDiretorPorIdFilme(int idFilme);
    }
}
