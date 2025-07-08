using basel.entity;
using basel.infra.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.service.Abstract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentAsync();
    }
}
