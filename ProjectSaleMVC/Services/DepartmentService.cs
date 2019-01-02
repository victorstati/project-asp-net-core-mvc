using ProjectSaleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjectSaleMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjectSaleMVCContext _context;

        public DepartmentService(ProjectSaleMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
