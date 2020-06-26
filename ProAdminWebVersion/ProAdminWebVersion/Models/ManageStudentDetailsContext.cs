using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAdminWebVersion.Models
{
    public class ManageStudentDetailsContext : DbContext
    {
        public ManageStudentDetailsContext(DbContextOptions<ManageStudentDetailsContext> options):base(options)
        {
                
        }

        public DbSet<StudentsDetail> StudentDetails { get; set; }
    }
}
