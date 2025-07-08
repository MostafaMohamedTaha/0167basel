using basel.entity;
using basel.infra.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.infra.Abstract
{
    public interface IStudentRepo:IGenericRepo<Student>
    {
        public Task<List<Student>> GetStudentListAsync();
    }
}
