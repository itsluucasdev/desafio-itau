using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using desafio_itau.Data;
using desafio_itau.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;

namespace desafio_itau.Controllers
{
    [ApiController]
    [Route("v1/cotacoes")]
    public class CotacaoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Cotacao>>> Get(
            [FromServices] DataContext context)
        {
            var cotacoes = await context.Cotacoes.Include(x => x.Taxa).ToListAsync();
            return cotacoes;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Cotacao>> GetById(
            [FromServices] DataContext context, 
            int id)
        {
            var product = await context.Cotacoes.Include(x => x.Taxa)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            return product;
        }

        [HttpGet]
        [Route("cotacoes/{id:int}")]
        public async Task<ActionResult<List<Cotacao>>> GetByTaxa(
            [FromServices] DataContext context, 
            int id)
        {
            var products = await context.Cotacoes.Include(x => x.Taxa)
                .Include(x => x.Taxa)
                .AsNoTracking()
                .Where(x => x.TaxaId == id)
                .ToListAsync();
            return products;
        }

        [HttpPost]
        [Route("{id:int}")]
        public async Task<ActionResult<Cotacao>> Post(
            [FromServices] DataContext context,
            [FromBody] Cotacao model)
        {
            if (ModelState.IsValid)
            {
                model = CalculaCompra(model);
                context.Cotacoes.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        public Cotacao CalculaCompra(Cotacao model)
        {
            /// a = ( b * y ) + (1 * o)
            /// a = valor em reais
            /// b = quantidade desejada da moeda estrangeira
            /// y = taxa de conversao
            /// o = parametrizacao por segmento

            var valorEmReais = ( (model.QtdeValorEstrangeiro * 5) + (1 * 1) );
            model.ValorEmReais = valorEmReais;
            return model;
        }
    }
}