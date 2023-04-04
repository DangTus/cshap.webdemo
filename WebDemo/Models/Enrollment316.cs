using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment316
    {
        public int Enrollment316ID { get; set; }
        public int Course316ID { get; set; }
        public int Student316ID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade316 { get; set; }

        public Course316 Course316 { get; set; }
        public Student316 Student316 { get; set; }
    }
}