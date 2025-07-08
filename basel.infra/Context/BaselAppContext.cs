using basel.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.infra.Context
{
    public class BaselAppContext
    {
        public class BaselDbContext(DbContextOptions<BaselDbContext> opt):DbContext(opt)
        {
            public DbSet<Department>? Departments { get; set; } = null!;
            public DbSet<Student>? Students { get; set; } = null!;
            public DbSet<Subject>? Subjects { get; set; } = null!;
            public DbSet<StudentSubject>? StudentSubjects { get; set; } = null!;
            public DbSet<DepartmentSubject>? DepartmentSubjects { get; set; } = null!;
        }
    }
}
