using Api_Filmes.Data;
using Api_Filmes.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Filmes.Services.Diretor
{
    public class DiretorService : DiretorInterface
    {
        private readonly AppDBContext _context;
        public DiretorService(AppDBContext context)
        { 
            _context = context;
        }

        public async Task<ResponseModel<DiretorModel>> BuscarDiretorPorId(int idDiretor)
        {

            ResponseModel<DiretorModel> response = new ResponseModel<DiretorModel>();
            try
            {

                var diretor = await _context.Diretores.FirstOrDefaultAsync(diretorbanco => diretorbanco.Id == idDiretor );

                if(diretor == null)
                {
                    response.Mensagem = "Diretor não encontrado.";
                    return response;
                }
             
                response.Dados = diretor;
                response.Mensagem = "Diretor encontrado com sucesso.";
                return response;



            } catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;
            }
        }

        public async Task<ResponseModel<DiretorModel>> BuscarDiretorPorIdFilme(int idFilme)
        {
            ResponseModel<DiretorModel> response = new ResponseModel<DiretorModel>();
            try
            {
               var filme = await _context.Filmes.Include(d => d.Diretor).FirstOrDefaultAsync(filmeBanco => filmeBanco.Id == idFilme);

                if (filme == null)
                {
                    response.Mensagem = "Nenhum registro encontrado.";
                    return response;
                }
                response.Dados = filme.Diretor;
                response.Mensagem = "Diretor encontrado com sucesso.";
                return response;


            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;

            }
        }

        public async Task<ResponseModel<List<DiretorModel>>> ListarDiretores()
        {
            ResponseModel<List<DiretorModel>> response = new ResponseModel<List<DiretorModel>>();
            try
            {

                var diretores = await _context.Diretores.ToListAsync();

                response.Dados = diretores;
                response.Mensagem = "Diretores listados com sucesso."; 

                return response;

            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;

            }
        }
    }
}
