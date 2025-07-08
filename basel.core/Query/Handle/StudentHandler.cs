using basel.core.Mapper.StudentMapper.Query.StudentDto;
using basel.core.Query.Query.StudentQuery;
using basel.core.Repo;
using basel.service.Abstract;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace basel.core.Query.Handle
{
    public class StudentHandler : ResHandler, IRequestHandler<GetStudentQuery, Res<List<StudentDto>>>
    {
        private readonly IStudentService _studentService;

        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<Res<List<StudentDto>>> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService!.GetStudentAsync();
            var studentDto = student.Adapt<List<StudentDto>>();
            return Success(studentDto);
        }


    }
}
