using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Crud.Models
{
    [MetadataType(typeof(StudentNew))]
    public partial class Student
    {
    }
    class StudentNew
    {
        [Required]
        public int sno { get; set; }
        [Required,Range(1,30)]
        [RegularExpression(@"^[a-zA-z]+$",ErrorMessage="AlphabitsOnly")]
        public string sname { get; set; }
        [Required, Range(1, 10)]
        public string course { get; set; }
        [Required]
        public double fee { get; set; }
    }
}