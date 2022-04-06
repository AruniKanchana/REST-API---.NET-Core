using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartsController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public ShoppingCartsController(ECommerceContext context)
        {
            _context = context;
        }

        // GET: api/ShoppingCarts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShoppingCart>>> GetShoppingCart()
        {
            return await _context.ShoppingCart.ToListAsync();
        }

        // GET: api/ShoppingCarts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShoppingCart>> GetShoppingCart(int id)
        {
            var shoppingCart = await _context.ShoppingCart.FindAsync(id);

            if (shoppingCart == null)
            {
                return NotFound();
            }

            return shoppingCart;
        }

        // PUT: api/ShoppingCarts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditShoppingCart(int id, ShoppingCart shoppingCart)
        {
            if (id != shoppingCart.CartId)
            {
                return BadRequest();
            }

            _context.Entry(shoppingCart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingCartExists(id))
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

        // POST: api/ShoppingCarts
        [HttpPost]
        public async Task<ActionResult> AddShoppingCart(ShoppingCart shoppingCart)
        {
            _context.ShoppingCart.Add(shoppingCart);
            var result = await _context.SaveChangesAsync();

            return Ok(result);
        }

        // DELETE: api/ShoppingCarts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ShoppingCart>> DeleteShoppingCart(int id)
        {
            var shoppingCart = await _context.ShoppingCart.FindAsync(id);
            if (shoppingCart == null)
            {
                return NotFound();
            }

            _context.ShoppingCart.Remove(shoppingCart);
            await _context.SaveChangesAsync();

            return shoppingCart;
        }

        private bool ShoppingCartExists(int id)
        {
            return _context.ShoppingCart.Any(e => e.CartId == id);
        }
    }
}
