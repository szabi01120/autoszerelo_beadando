using Microsoft.AspNetCore.Mvc;
using autoszerelo_szerver.Model;
using Microsoft.EntityFrameworkCore;

namespace autoszerelo_szerver.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<DatabaseController> _logger;

        public DatabaseController(AppDbContext dbContext, ILogger<DatabaseController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var letezo_munka = await _dbContext.Munkak.FindAsync(id);

            if (letezo_munka is null)
            {
                return NotFound();
            }

            //try - catch !
            _dbContext.Munkak.Remove(letezo_munka);

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Munka>>> GetMunkak()
        {
            var osszes_munka = await _dbContext.Munkak.ToListAsync();
            return Ok(osszes_munka);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Munka>>> GetEgyMunka(string id)
        {
            var adott_munka = await _dbContext.Munkak.FindAsync(id);

            if (adott_munka is null)
            {
                return NotFound();
            }

            return Ok(adott_munka);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Munka munka)
        {
            _dbContext.Munkak.Add(munka);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Munka munka)
        {
            if (id != munka.Nev)
            {
                return BadRequest();
            }

            var letezo_munka = await _dbContext.Munkak.FindAsync(id);

            //TOBBI ATTRIBUTUM FELULIRASA...
            letezo_munka.Leiras = munka.Leiras;

            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
