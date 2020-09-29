using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCRUD.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Fullname")]
        public string FullName { get; set; }

        [DisplayName("Emp. Code")]
        [Column(TypeName = "varchar(10)")]
        public string EmpCode { get; set; }

        [DisplayName("Position")]
        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }

        [DisplayName("Office Location")]
        [Column(TypeName = "varchar(100)")]
        public string OfficeLocation { get; set; } 
    }
}
