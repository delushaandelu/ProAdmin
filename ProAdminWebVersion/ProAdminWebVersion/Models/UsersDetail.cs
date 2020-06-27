using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProAdminWebVersion.Models
{
    public class UsersDetail
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string fullname { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string nic { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string email { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string phone { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string role { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string status { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string username { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string password { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string log { get; set; }
    }
}
