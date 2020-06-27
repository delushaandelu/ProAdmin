using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProAdminWebVersion.Models
{
    public class SubjectDetail
    {
        [Key]
        public int subid { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string subject { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string teacher { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string log { get; set; }
    }
}
