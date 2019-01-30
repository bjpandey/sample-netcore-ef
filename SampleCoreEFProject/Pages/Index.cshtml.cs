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
    public class IndexModel : PageModel
    {
        private readonly SampleCoreEFProject.Models.SampleCoreEFProjectContext _context;

        public IndexModel(SampleCoreEFProject.Models.SampleCoreEFProjectContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
