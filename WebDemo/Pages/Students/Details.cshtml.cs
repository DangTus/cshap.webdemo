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
    public class DetailsModel : PageModel
    {
        private readonly WebDemo.Data.SchoolContext _context;

        public DetailsModel(WebDemo.Data.SchoolContext context)
        {
            _context = context;
        }

        public Student316 Student316 { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student316 = await _context.Students
                .Include(s => s.Enrollments316)
                .ThenInclude(e => e.Course316)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Student316 == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
