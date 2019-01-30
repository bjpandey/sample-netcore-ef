using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleCoreEFProject.Models;

namespace SampleCoreEFProject.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly SampleCoreEFProject.Models.SampleCoreEFProjectContext _context;

        public DetailsModel(SampleCoreEFProject.Models.SampleCoreEFProjectContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
