using basel.entity;
using basel.infra.Abstract;
using basel.infra.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static basel.infra.Context.BaselAppContext;

namespace basel.infra.Repo
{
    public class StudentRepo: GenericRepo<Student>,IStudentRepo
    {
        //private readonly BaselDbContext? _baselContext;
        private readonly DbSet<Student> _student;

        public StudentRepo(BaselDbContext baselContext):base(baselContext) 
        {
            _student = baselContext.Set<Student>();
        }

        public  async Task<List<Student>> GetStudentListAsync()
        {
            return await _student.Include(x => x.Departments).ToListAsync();
        }

    }
}
