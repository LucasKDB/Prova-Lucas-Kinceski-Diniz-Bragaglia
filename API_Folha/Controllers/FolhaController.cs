using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaController : ControllerBase
    {
        private readonly DataContext _context;
        public FolhaController(DataContext context) =>
            _context = context;

        // GET: /api/funcionario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Folhas.ToList());

        // POST: /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Folha folha)
        {
            _context.Folhas.Add(folha);
            _context.SaveChanges();
            return Created("", folha);
        }

        // GET: /api/funcionario/buscar/{cpf}
        [HttpGet]
        [Route("buscar/{folhaid}")]
        public IActionResult Buscar([FromRoute] string folhaid)
        {
            Folha folha = _context.Folhas.
                FirstOrDefault(f => f.folhaid.Equals(folhaid));
            return folha != null ? Ok(folha) : NotFound();
        }

        // DELETE: /api/funcionario/deletar/{id}
        [HttpDelete]
        [Route("deletar/{folhaid}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Folha folha = _context.Folhas.Find(id);
            if (folha != null)
            {
                _context.Folhas.Remove(folha);
                _context.SaveChanges();
                return Ok(folha);
            }
            return NotFound();
        }

        // PATCH: /api/funcionario/alterar
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Folha folha)
        {
            try
            {
                _context.Folhas.Update(folha);
                _context.SaveChanges();
                return Ok(folha);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}