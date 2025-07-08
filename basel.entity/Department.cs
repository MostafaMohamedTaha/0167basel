using System.ComponentModel.DataAnnotations;

namespace basel.entity
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;
        [StringLength(100)]

        public string Address { get; set; } = string.Empty;
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; } = new HashSet<DepartmentSubject>();
        
    }
}