using basel.core.Mapper.StudentMapper.Query.StudentDto;
using basel.core.Repo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.core.Query.Query.StudentQuery
{
    public class GetStudentByIdQuery : IRequest<Res<StudentByIdDto>>
    {
        public int Id { get; set; }
        public GetStudentByIdQuery(int id)
        {
            Id=id;
        }
    }
}
