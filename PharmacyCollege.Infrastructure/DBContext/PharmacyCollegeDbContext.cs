using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PharmacyCollege.Domain.Entities;

namespace PharmacyCollege.Infrastructure.DBContext
{
    public class PharmacyCollegeDbContext: DbContext
    {
        public PharmacyCollegeDbContext(DbContextOptions<PharmacyCollegeDbContext> options)
            : base(options)
        {

        }
        public DbSet<FacultyMember> FacultyMembers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<ResearchProject> ResearchProjects { get; set; }
    }
}
