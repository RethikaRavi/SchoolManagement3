using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiSchoolManagement3.Controllers.Model;

namespace WebApiSchoolManagement3.Data
{
    public class SchoolDbcontextSchoolManagement3Context : DbContext
    {
        public SchoolDbcontextSchoolManagement3Context (DbContextOptions<SchoolDbcontextSchoolManagement3Context> options)
            : base(options)
        {
        }

        public DbSet<WebApiSchoolManagement3.Controllers.Model.School> School { get; set; } = default!;
    }
}
