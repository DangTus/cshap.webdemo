using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;
using WebDemo.Data;

namespace WebDemo.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly WebDemo.Data.SchoolContext _context;

        public EditModel(WebDemo.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student316 Student316 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student316 = await _context.Students.FindAsync(id);

            if (Student316 == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var studentToUpdate = await _context.Students.FindAsync(id);

            if (studentToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Student316>(
                studentToUpdate,
                "student",
                s => s.FirstMidName316, s => s.LastName316, s => s.EnrollmentDate316))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }

        private bool Student316Exists(int id)
        {
            return _context.Students.Any(e => e.ID == id);
        }
    }
}
