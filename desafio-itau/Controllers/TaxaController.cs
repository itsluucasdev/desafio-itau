using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_itau.Data;
using desafio_itau.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace desafio_itau.Controllers
{
    [ApiController]
    [Route("v1/taxas")]
    public class TaxaController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Taxa>>> Get([FromServices] DataContext context)
        {
            var taxas = await context.Taxas.ToListAsync();
            return taxas;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Taxa>> Post(
            [FromServices] DataContext context,
            [FromBody] Taxa model)
        {
            if (ModelState.IsValid)
            {
                context.Taxas.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}