using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.entity
{
    public class DepartmentSubject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;
        [InverseProperty("Department")]
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
        [InverseProperty("Subject")]
        [ForeignKey("SubjectId")]
        public int SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }

    }
}
