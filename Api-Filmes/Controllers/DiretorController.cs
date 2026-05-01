using Api_Filmes.DTO.DiretorDTO;
using Api_Filmes.Models;
using Api_Filmes.Services.Diretor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Filmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiretorController : ControllerBase
    {

        private readonly DiretorInterface _diretorinterface;
        public DiretorController(DiretorInterface diretorinterface)
        {
            _diretorinterface = diretorinterface;
        }

        [HttpGet("ListarDiretores")]
        public async Task<ActionResult<ResponseModel<List<DiretorModel>>>> ListarDiretores()
        {
            var Diretores = await _diretorinterface.ListarDiretores();
            return Ok(Diretores);
        }

        [HttpGet("BuscarDiretorPorId/{idDiretor}")]
        public async Task<ActionResult<ResponseModel<DiretorModel>>> BuscarDiretorPorId(int idDiretor)
        {
            var Diretor = await _diretorinterface.BuscarDiretorPorId(idDiretor);
            return Ok(Diretor);
        }

        [HttpGet("BuscarDiretorPorIdFilme/{idFilme}")]
        public async Task<ActionResult<ResponseModel<DiretorModel>>> BuscarDireBuscarDiretorPorIdFilmed(int idFilme)
        {
            var Diretor = await _diretorinterface.BuscarDiretorPorIdFilme(idFilme);
            return Ok(Diretor);
        }

        [HttpPost("CadastrarDiretor")]
        public async Task<ActionResult<ResponseModel<List<DiretorModel>>>> CadastrarDiretor(DiretorCriaçãoDTO diretorCriaçãoDTO)
        {
            var Diretor = await _diretorinterface.CadastrarDiretor(diretorCriaçãoDTO);
            return Ok(Diretor);
        }

        [HttpPut("EditarDiretor")]
        public async Task<ActionResult<ResponseModel<List<DiretorModel>>>> EditarDiretor(DiretorEdiçãoDTO diretorEdiçãoDTO)
        {
            var Diretor = await _diretorinterface.EditarDiretor(diretorEdiçãoDTO);
            return Ok(Diretor);
        }

        [HttpDelete("RemoverDiretor")]
        public async Task<ActionResult<ResponseModel<List<DiretorModel>>>> RemoverDiretor(int idDiretor)
        {
            var Diretor = await _diretorinterface.RemoverDiretor(idDiretor);
            return Ok(Diretor);
        }
    }
}
