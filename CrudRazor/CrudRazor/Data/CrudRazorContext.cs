using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudRazor.Model;

namespace CrudRazor.Data
{
    public class CrudRazorContext : DbContext
    {
        public CrudRazorContext (DbContextOptions<CrudRazorContext> options)
            : base(options)
        {
        }

        public DbSet<CrudRazor.Model.Produto> Produto { get; set; } = default!;
    }
}
