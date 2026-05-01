using Api_Filmes.DTO.DiretorDTO;
using Api_Filmes.Models;

namespace Api_Filmes.Services.Diretor
{
    public interface DiretorInterface
    {
        Task<ResponseModel<List<DiretorModel>>> ListarDiretores();
        Task<ResponseModel<DiretorModel>> BuscarDiretorPorId(int idDiretor);
        Task<ResponseModel<DiretorModel>> BuscarDiretorPorIdFilme(int idFilme);
        Task<ResponseModel<DiretorModel>> CadastrarDiretor(DiretorCriaçãoDTO diretorCriaçãoDTO);

        Task<ResponseModel<List<DiretorModel>>> EditarDiretor(DiretorEdiçãoDTO diretorEdiçãoDTO);

        Task<ResponseModel<List<DiretorModel>>> RemoverDiretor(int idDiretor);
    }
}
