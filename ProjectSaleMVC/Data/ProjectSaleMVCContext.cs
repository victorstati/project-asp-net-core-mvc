using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectSaleMVC.Models
{
    public class ProjectSaleMVCContext : DbContext
    {
        public ProjectSaleMVCContext (DbContextOptions<ProjectSaleMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectSaleMVC.Models.Department> Department { get; set; }
    }
}
