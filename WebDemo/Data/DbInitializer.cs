using ContosoUniversity.Models;
using WebDemo.Data;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student316[]
            {
                new Student316{FirstMidName316="Carson",    LastName316="Alexander",    EnrollmentDate316=DateTime.Parse("2019-09-01")},
                new Student316{FirstMidName316="Meredith",  LastName316="Alonso",       EnrollmentDate316=DateTime.Parse("2017-09-01")},
                new Student316{FirstMidName316="Arturo",    LastName316="Anand",        EnrollmentDate316=DateTime.Parse("2018-09-01")},
                new Student316{FirstMidName316="Gytis",     LastName316="Barzdukas",    EnrollmentDate316=DateTime.Parse("2017-09-01")},
                new Student316{FirstMidName316="Yan",       LastName316="Li",           EnrollmentDate316=DateTime.Parse("2017-09-01")},
                new Student316{FirstMidName316="Peggy",     LastName316="Justice",      EnrollmentDate316=DateTime.Parse("2016-09-01")},
                new Student316{FirstMidName316="Laura",     LastName316="Norman",       EnrollmentDate316=DateTime.Parse("2018-09-01")},
                new Student316{FirstMidName316="Nino",      LastName316="Olivetto",     EnrollmentDate316=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course316[]
            {
                new Course316{Course316ID=1050,Title316="Chemistry",        Credits316=3},
                new Course316{Course316ID=4022,Title316="Microeconomics",   Credits316=3},
                new Course316{Course316ID=4041,Title316="Macroeconomics",   Credits316=3},
                new Course316{Course316ID=1045,Title316="Calculus",         Credits316=4},
                new Course316{Course316ID=3141,Title316="Trigonometry",     Credits316=4},
                new Course316{Course316ID=2021,Title316="Composition",      Credits316=3},
                new Course316{Course316ID=2042,Title316="Literature",       Credits316=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment316[]
            {
                new Enrollment316{Student316ID=1,Course316ID=1050,Grade316=Grade.A},
                new Enrollment316{Student316ID=1,Course316ID=4022,Grade316=Grade.C},
                new Enrollment316{Student316ID=1,Course316ID=4041,Grade316=Grade.B},
                new Enrollment316{Student316ID=2,Course316ID=1045,Grade316=Grade.B},
                new Enrollment316{Student316ID=2,Course316ID=3141,Grade316=Grade.F},
                new Enrollment316{Student316ID=2,Course316ID=2021,Grade316=Grade.F},
                new Enrollment316{Student316ID=3,Course316ID=1050},
                new Enrollment316{Student316ID=4,Course316ID=1050},
                new Enrollment316{Student316ID=4,Course316ID=4022,Grade316=Grade.F},
                new Enrollment316{Student316ID=5,Course316ID=4041,Grade316=Grade.C},
                new Enrollment316{Student316ID=6,Course316ID=1045},
                new Enrollment316{Student316ID=7,Course316ID=3141,Grade316=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}