using Master.Rotas.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Master.Rotas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RotasController : Controller
    {
        private readonly ApiDbContext _context;

        public RotasController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rota>>> ObterRotas()
        {
            return await _context.Rotas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rota>> ObterRotaPorId(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rota = await _context.Rotas.FindAsync(id);

            if (rota == null)
            {
                return NotFound();
            }

            return rota;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Editar(Guid id, Rota rota)
        {
            if (id != rota.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RotaExists(rota.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Criar(Rota rota)
        {
            if (ModelState.IsValid)
            {
                rota.Id = Guid.NewGuid();
                _context.Add(rota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return CreatedAtAction("ObterRotaPorId", new { id = rota.Id }, rota);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Rota>> Remover(Guid id)
        {
            var rota = await _context.Rotas.FindAsync(id);
            
            if (rota == null)
            {
                return NotFound();
            }

            _context.Rotas.Remove(rota);
            await _context.SaveChangesAsync();

            return rota;
        }

        private bool RotaExists(Guid id)
        {
            return _context.Rotas.Any(e => e.Id == id);
        }
    }
}
