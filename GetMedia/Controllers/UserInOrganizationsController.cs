using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GetMedia.Models;

namespace GetMedia.Controllers
{
    [Produces("application/json")]
    [Route("api/UserInOrganizations")]
    public class UserInOrganizationsController : Controller
    {
        private readonly GetMediaContext _context;

        public UserInOrganizationsController(GetMediaContext context)
        {
            _context = context;
        }

        // GET: api/UserInOrganizations
        [HttpGet]
        public IEnumerable<UserInOrganization> GetUserInOrganization()
        {
            return _context.UserInOrganization;
        }

        // GET: api/UserInOrganizations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserInOrganization([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userInOrganization = await _context.UserInOrganization.SingleOrDefaultAsync(m => m.UserId == id);

            if (userInOrganization == null)
            {
                return NotFound();
            }

            return Ok(userInOrganization);
        }

        // PUT: api/UserInOrganizations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserInOrganization([FromRoute] int id, [FromBody] UserInOrganization userInOrganization)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userInOrganization.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userInOrganization).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserInOrganizationExists(id))
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

        // POST: api/UserInOrganizations
        [HttpPost]
        public async Task<IActionResult> PostUserInOrganization([FromBody] UserInOrganization userInOrganization)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UserInOrganization.Add(userInOrganization);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserInOrganizationExists(userInOrganization.UserId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserInOrganization", new { id = userInOrganization.UserId }, userInOrganization);
        }

        // DELETE: api/UserInOrganizations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserInOrganization([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userInOrganization = await _context.UserInOrganization.SingleOrDefaultAsync(m => m.UserId == id);
            if (userInOrganization == null)
            {
                return NotFound();
            }

            _context.UserInOrganization.Remove(userInOrganization);
            await _context.SaveChangesAsync();

            return Ok(userInOrganization);
        }

        private bool UserInOrganizationExists(int id)
        {
            return _context.UserInOrganization.Any(e => e.UserId == id);
        }
    }
}