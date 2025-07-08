using basel.entity;
using basel.infra.Abstract;
using basel.infra.Repo;
using basel.service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.service.Repo
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepo? _studentRepo;

        public StudentService(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }


        public async Task<List<Student>> GetStudentAsync()
        {
            return await _studentRepo!.GetStudentListAsync();
        }
    }
}
