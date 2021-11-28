using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borsos_Brigitte_Lab5.Models
{
    public class ExpenseContext : DbContext
    {
         public ExpenseContext(DbContextOptions<ExpenseContext> options): base(options)
        {
        }
        public DbSet<Expenses> Expense { get; set; }
        public object ExpenseDTO { get; internal set; }
    }
}
