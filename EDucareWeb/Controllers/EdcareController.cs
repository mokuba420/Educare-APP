using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDucareWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EDucareWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EdcareController : ControllerBase
    {
        private readonly information _context;

        public EdcareController(information context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<UserInformation>> GetAll() =>
           _context.UserInformation.ToList();

        [HttpGet("{id}")]
        public async Task<ActionResult<UserInformation>> GetById(long id)
        {
            var product = await _context.UserInformation.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, UserInformation product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<UserInformation>> Create(UserInformation product)
        {
            _context.UserInformation.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var product = await _context.UserInformation.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.UserInformation.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
    
    
    
    
    
    
