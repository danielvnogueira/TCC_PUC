using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio.WebAPI.Data;
using Consultorio.WebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class ValuesController : ControllerBase
    {
        public readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _context.Agendas.ToListAsync();

                return Ok(results);

            }
            catch
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou!");

            }
        }

        // GET api/values/5
        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var results = await _context.Agendas.FirstOrDefaultAsync(x => x.AgendaId == id);

                return Ok(results);

            }
            catch
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou!");

            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
