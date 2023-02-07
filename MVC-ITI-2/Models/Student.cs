using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ITI_2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [StringLength(20)]
        public string Email { get; set; }
        [Required]
        [StringLength(20,MinimumLength =3)]
        public string UserName { get; set; }
        public int DeptNo { get; set; }
        [ForeignKey("DeptNo")]
        public virtual Department Department { get; set; }
    }
}
