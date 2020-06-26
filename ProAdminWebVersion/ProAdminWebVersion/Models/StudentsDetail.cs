using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProAdminWebVersion.Models
{
    public class StudentsDetail
    {
        [Key]
        public int Sid { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string RegId { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Nic { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Dob { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string HomeAdress { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string HomeTell { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string StayAddress { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string StayHomeTell { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string FatherName { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string ParentsTell { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string OlSchool { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string AlSchool { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string  OlResult { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string JoinedDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Batch { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Scholership { get; set; }



    }
}
