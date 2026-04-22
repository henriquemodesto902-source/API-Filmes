using Api_Filmes.Data;
using Api_Filmes.Models;

namespace Api_Filmes.Services.Diretor
{
    public class DiretorService : DiretorInterface
    {
        private readonly AppDBContext _context;
        public DiretorService(AppDBContext context)
        { 
            _context = context;
        }

        public Task<ResponseModel<DiretorModel>> BuscarDiretorPorId(int idDiretor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DiretorModel>> BuscarDiretorPorIdFilme(int idFilme)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<DiretorModel>>> ListarDiretores()
        {
            throw new NotImplementedException();
        }
    }
}
