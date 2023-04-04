namespace ContosoUniversity.Models
{
    public class Student316
    {
        public int ID { get; set; }
        public string LastName316 { get; set; }
        public string FirstMidName316 { get; set; }
        public DateTime EnrollmentDate316 { get; set; }

        public ICollection<Enrollment316> Enrollments316 { get; set; }
    }
}