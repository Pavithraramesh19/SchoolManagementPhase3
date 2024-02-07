using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiSchoolManagement3.Controllers.Models;

namespace WebApiSchoolManagement3.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext (DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiSchoolManagement3.Controllers.Models.School> School { get; set; } = default!;
    }
}
