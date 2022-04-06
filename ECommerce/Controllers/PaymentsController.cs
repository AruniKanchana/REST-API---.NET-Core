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
    public class PaymentsController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public PaymentsController(ECommerceContext context)
        {
            _context = context;
        }

        // GET: api/Payments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayment()
        {
            return await _context.Payment.ToListAsync();
        }

        // GET: api/Payments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPayment(int id)
        {
            var payment = await _context.Payment.FindAsync(id);

            if (payment == null)
            {
                return NotFound();
            }

            return payment;
        }

        // PUT: api/Payments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditPayment(int id, Payment payment)
        {
            if (id != payment.PaymentId)
            {
                return BadRequest();
            }

            _context.Entry(payment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentExists(id))
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

        // POST: api/Payments
        [HttpPost]
        public async Task<ActionResult> AddPayment(Payment payment)
        {
            _context.Payment.Add(payment);
            var result = await _context.SaveChangesAsync();

            return Ok(result);
        }

        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Payment>> DeletePayment(int id)
        {
            var payment = await _context.Payment.FindAsync(id);
            if (payment == null)
            {
                return NotFound();
            }

            _context.Payment.Remove(payment);
            await _context.SaveChangesAsync();

            return payment;
        }

        private bool PaymentExists(int id)
        {
            return _context.Payment.Any(e => e.PaymentId == id);
        }
    }
}
