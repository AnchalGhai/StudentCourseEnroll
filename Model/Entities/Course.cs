using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Model.Entities
{

    [Table("Course")]
    public class Course
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("title")]
        public string? Title { get; set; }

        [Column("credits")]
        public int Credits { get; set; }

        // public ICollection&lt;Enrollment&gt; Enrollments { get; set; }
    }
}