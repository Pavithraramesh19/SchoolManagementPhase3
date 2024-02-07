using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSchoolManagement3.Controllers.Models
{
    [Table("School")]
    public class School
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Subject { get; set; }
        public int Marks { get; set; }
    }
}
