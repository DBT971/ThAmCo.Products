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
    [Route("/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDBContext _context;

        public ProductsController(ProductsDBContext context)
        {
            _context = context;
        }

        // GET: Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductGetDto>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            if(products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        // GET: Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductGetDto>> GetProducts(int id)
        {
            var products = await _context.Products.FindAsync(id);

            if (products == null)
            {
                return NotFound();
            }

            return Ok(ProductGetDto.FromModel(products));
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducts(int id, ProductGetDto products)
        {
            if (id != products.ID)
            {
                return BadRequest();
            }

            _context.Entry(products).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsExists(id))
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

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
