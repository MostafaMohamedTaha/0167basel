using basel.core.Mapper.StudentMapper.Query.StudentDto;
using basel.entity;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.core.Mapper.StudentMapper
{
    public class StudentProfile:IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Student, StudentDto>()
                    .Map(dest => dest.DepartmentName,
                    src => src.Departments != null ?
                    src.Departments.Name : null);
            config.NewConfig<Student, StudentByIdDto>()
                    .Map(dest => dest.DepartmentName,
                    src => src.Departments != null ?
                    src.Departments.Name : null);
        }
    }
}
