using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Freedom.App.DataAccess.DTO
{
    [Table("Registration")]
    public class RegistrationFormDto
    {
        [Key, Column("Id")]
        public int Id { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("MiddleName")]
        public string MiddleName { get; set; }

        [Column("Class")]
        public string Claass { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Gender")]
        public string Gender { get; set; }
    }
}
