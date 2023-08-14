using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using University_API.DataAccess;
using University_API.Models;
using University_API.Services;

namespace University_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
       // private readonly UniversityContext _context;
        private readonly Services.Services _service;
       // public UsersController(UniversityContext context, LinqQueries linqQueries)

        public UsersController(Services.Services service)
        {
            //  _context = context;
            _service = service;           

        }
        
        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _service.GetUsers();
           
          if (users == null)
          {
              return NotFound();
          }
            return  users.ToList();
        }

            // GET: api/Users/5
            [HttpGet("/api/Users/Lista/{id}")]
        public ActionResult<User> GetUser(int id)
        {
            User user = _service.GetUser(id);
            
            if (user == null)
            {
                return NotFound();
            }
          
            else
            {
                return Ok(user);
            }  
        }

        

        
        [HttpGet("/api/Users/Uno{email}")]
        public async Task<ActionResult<User>> SearchUsersByEmail(string email)
        {           
            return Ok(_service.SearchUsersByEmail(email));
        }

        
        /*

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

       

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
          if (_context.Users == null)
          {
              return Problem("Entity set 'UniversityContext.Users'  is null.");
          }
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        */
    }
        
}
