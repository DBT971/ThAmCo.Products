using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Products.Data;
using ThAmCo.Products.Models;

namespace ThAmCo.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductGetDtoesController : ControllerBase
    {
        private readonly ProductsContext _context;

        //Testing Development Branch

        public ProductGetDtoesController(ProductsContext context)
        {
            _context = context;
        }

        // GET: api/ProductGetDtoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductGetDto>>> GetProductGetDto()
        {
            return await _context.ProductGetDto.ToListAsync();
        }

        // GET: api/ProductGetDtoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductGetDto>> GetProductGetDto(int id)
        {
            var productGetDto = await _context.ProductGetDto.FindAsync(id);

            if (productGetDto == null)
            {
                return NotFound();
            }

            return productGetDto;
        }

        // PUT: api/ProductGetDtoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductGetDto(int id, ProductGetDto productGetDto)
        {
            if (id != productGetDto.ID)
            {
                return BadRequest();
            }

            _context.Entry(productGetDto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductGetDtoExists(id))
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

        // POST: api/ProductGetDtoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProductGetDto>> PostProductGetDto(ProductGetDto productGetDto)
        {
            _context.ProductGetDto.Add(productGetDto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductGetDto", new { id = productGetDto.ID }, productGetDto);
        }

        // DELETE: api/ProductGetDtoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductGetDto>> DeleteProductGetDto(int id)
        {
            var productGetDto = await _context.ProductGetDto.FindAsync(id);
            if (productGetDto == null)
            {
                return NotFound();
            }

            _context.ProductGetDto.Remove(productGetDto);
            await _context.SaveChangesAsync();

            return productGetDto;
        }

        private bool ProductGetDtoExists(int id)
        {
            return _context.ProductGetDto.Any(e => e.ID == id);
        }
    }
}
