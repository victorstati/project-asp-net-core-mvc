using ProjectSaleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectSaleMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjectSaleMVCContext _context;

        public DepartmentService(ProjectSaleMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
