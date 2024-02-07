using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSchoolManagement3.Controllers.Model
{
    [Table("School")]
    public class School
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Subjects { get; set; }
        public int Marks { get; set; }
    }
}
