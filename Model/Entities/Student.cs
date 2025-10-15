using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Model.Entities
{
    [Table("Student")]
    public class Student
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("age")]
        public int Age { get; set; }

    }
}