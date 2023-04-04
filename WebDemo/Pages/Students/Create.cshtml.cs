using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Models;
using WebDemo.Data;

namespace WebDemo.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly WebDemo.Data.SchoolContext _context;

        public CreateModel(WebDemo.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student316 Student316 { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyStudent = new Student316();

            if (await TryUpdateModelAsync<Student316>(
                emptyStudent,
                "student",   // Prefix for form value.
                s => s.FirstMidName316, s => s.LastName316, s => s.EnrollmentDate316))
            {
                _context.Students.Add(emptyStudent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
