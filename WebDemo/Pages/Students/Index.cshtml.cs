using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;
using WebDemo.Data;

namespace WebDemo.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly WebDemo.Data.SchoolContext _context;

        public IndexModel(WebDemo.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student316> Student316 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Student316 = await _context.Students.ToListAsync();
            }
        }
    }
}
