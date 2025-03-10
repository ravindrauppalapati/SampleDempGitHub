using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleDempGitHub.Data;
using SampleDempGitHub.Models;

namespace SampleDempGitHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDBContext _context;
        public AccountController(AppDBContext context)
        {
            _context = context;
        }
        

        [HttpGet]
        public async Task<List<Employee>> getAllEmployees()
        {
            return await _context.employees.ToListAsync();
        }

        //[HttpGet]
        //public async Task<Employee> getEmployeesById(int id)
        //{
        //    return await _context.employees.FindAsync(id);
        //}

        [HttpPost]
        public async Task<IActionResult> createEmp([FromBody] Employee emp)
        {
           await _context.AddAsync(emp);
            await _context.SaveChangesAsync();

            return Ok(emp);
        }
    }
}
