using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudRazor.Data;
using CrudRazor.Model;

namespace CrudRazor.Pages.Produtos
{
    public class EditarModel : PageModel
    {
        private readonly CrudRazor.Data.CrudRazorContext _context;

        public EditarModel(CrudRazor.Data.CrudRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Produto Produto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto.FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            Produto = produto;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var produto = await _context.Produto.FindAsync(Produto.Id);

                produto.Nome = Produto.Nome;
                produto.Quantidade = Produto.Quantidade;

                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();

        }
    }
}
