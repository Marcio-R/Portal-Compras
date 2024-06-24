using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudRazor.Data;
using CrudRazor.Model;

namespace CrudRazor.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        private readonly CrudRazor.Data.CrudRazorContext _context;

        public IndexModel(CrudRazor.Data.CrudRazorContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
