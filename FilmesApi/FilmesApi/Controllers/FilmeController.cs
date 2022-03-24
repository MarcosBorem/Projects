using AutoMapper;
using FilmesApi.Context;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;
        public FilmeController(FilmeContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<Filme>> AdicionarFilme(Filme filme)
        {
            _context.Filme.Add(filme);
           
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FilmeExists(filme.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return CreatedAtAction(nameof(RecuperarFilmesPorId), new { Id = filme.Id }, filme);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Filme>>> RetornarFilme()
        {
            return await _context.Filme.ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> RecuperarFilmesPorId(int id)
        {
          var filme =  await _context.Filme.FindAsync(id);
            if (filme == null)
            {
                return NotFound();
            }
            return Ok(filme);
            
        }
        [HttpDelete("{id}")]
        public  async Task<IActionResult> DeletarFilmeById(int id)
        {
             var filme = await _context.Filme.FindAsync(id);
            if (filme == null)
            {
                return NotFound();
            }
            _context.Filme.Remove(filme);
            await _context.SaveChangesAsync();
            var novalistafilme = _context.Filme;
            return Ok(novalistafilme);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarFilme(int id, Filme filme)
        {
            if (id != filme.Id)
            {
                return BadRequest();
            }

            _context.Entry(filme).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        private bool FilmeExists(int id)
        {
            return _context.Filme.Any(e => e.Id == id);
        }

    }
}
