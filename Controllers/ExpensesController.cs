using ExpenseTracker.API.Models;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {

        private readonly ExpenseDbContext _context;

        public ExpensesController(ExpenseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expense>>> GetExpenses()
        {
            return await _context.Expenses.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Expense>> CreateExpense(
        [FromBody] Expense expense)
        {
            _context.Expenses.Add(expense);

            await _context.SaveChangesAsync();
            return Ok(expense);

            // Aquí agregaremos la respuesta.
        }
    }
}