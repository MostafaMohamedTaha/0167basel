using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.entity
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }=new HashSet<StudentSubject>();
        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }=new HashSet<DepartmentSubject>();



    }
}
