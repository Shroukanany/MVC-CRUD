using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ITI_2.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }
        [Required]
        [MaxLength(50)]
        public string DeptName { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
