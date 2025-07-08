using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.entity
{
    public class StudentSubject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        [InverseProperty("Subject")]
        [ForeignKey("SubjectId")]
        public int SubjectId { get; set; }
        public virtual Subject? Subjects { get; set; }
        [InverseProperty("Student")]
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        public virtual Student? Students { get; set; }
    }
}
