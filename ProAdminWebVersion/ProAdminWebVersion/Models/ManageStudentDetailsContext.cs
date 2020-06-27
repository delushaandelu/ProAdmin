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

        public DbSet<BatchDetail> BatchDetails { get; set; }

        public DbSet<SchoolDetail> SchoolDetails { get; set; }

        public DbSet<SubjectDetail> SubjectDetails { get; set; }

        public DbSet<UniversityDetail> UniversityDetails { get; set; }

        public DbSet<UsersDetail> UsersDetails { get; set; }
    }
}
