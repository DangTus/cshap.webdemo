using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course316
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Course316ID { get; set; }
        public string Title316 { get; set; }
        public int Credits316 { get; set; }

        public ICollection<Enrollment316> Enrollments316 { get; set; }
    }
}