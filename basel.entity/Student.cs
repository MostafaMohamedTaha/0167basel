using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.entity
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        [StringLength(50)]
        public string FirstName { get; set; }
        = string.Empty;
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        [StringLength(50)]
        public string PhoneNumber { get; set; } = string.Empty;
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public virtual Department? Departments { get; set; } 
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }=new HashSet<StudentSubject>();

    }
}
