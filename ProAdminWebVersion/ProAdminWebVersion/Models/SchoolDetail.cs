using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ProAdminWebVersion.Models
{
    public class SchoolDetail
    {
        [Key]
        public int schid { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string schoolname { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string log { get; set; }
    }
}
