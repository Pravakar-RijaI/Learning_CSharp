using System.ComponentModel.DataAnnotations;

namespace entities.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public string Marks { get; set; }

    }
}
