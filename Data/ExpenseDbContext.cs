using ExpenseTracker.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ExpenseTracker.API.Data
{
    public class ExpenseDbContext : DbContext
    {
        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}