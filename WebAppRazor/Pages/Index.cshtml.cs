using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppRazor.Models;

namespace WebAppRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebAppRazor.Models.EmployeeDBContext _context;

        public IndexModel(WebAppRazor.Models.EmployeeDBContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
