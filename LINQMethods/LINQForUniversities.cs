using FirstLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLINQ.LINQMethods
{
    internal class LINQForUniversities
    {
        public List<University> GetAll()
        {
            List<University> list = new List<University>()
            {
                new University { Id = 1, Name = "PDP", Location = "Chilonzor", Students  =
                new List<Student>() {
                    new Student() { Id = 1, Age = 27, Grant = false, FirstName = "Akramjon", LastName = "Abduvahobov" },
                    new Student() { Id = 2, Age = 20, Grant = true, FirstName = "Abduxoliq", LastName = "Abduxoliqov" },
                    new Student() { Id = 3, Age = 23, Grant = false, FirstName = "Muhammad Abdulloh", LastName = "Muhammad Abdullohov" },
                    new Student() { Id = 4, Age = 40, Grant = true, FirstName = "Ikromjon", LastName = "Ikromjon" },
                } },
                new University { Id = 2, Name = "Mohirdev", Location = "Mirzo Ulug'bek", Students  =
                new List<Student>() {
                    new Student() { Id = 1, Age = 30, Grant = true, FirstName = "Akramjon Mohirdev", LastName = "Abduvahobov Mohirdev" },
                    new Student() { Id = 2, Age = 17, Grant = false, FirstName = "Abduxoliq Mohirdev", LastName = "Abduxoliqov Mohirdev" },
                    new Student() { Id = 3, Age = 20, Grant = false, FirstName = "Muhammad Abdulloh Mohirdev", LastName = "Muhammad Abdullohov Mohirdev" },
                    new Student() { Id = 4, Age = 31, Grant = false, FirstName = "Ikromjon Mohirdev", LastName = "Ikromjon Mohirdev" },
                } },

            };

            return list;
        }

        public IEnumerable<string> GetAllCenter()
        {
            var centers = GetAll().Select(x => x.Name);

            return centers;
        }

        public IEnumerable<University> GetCenterByName(string name)
        {
            var centers = GetAll().Select(x => x).Where(z => z.Name == name);

            return centers;
        }

        public IEnumerable<Student> GetStudentByGrantWithUniversity(string univerName)
        {
            var result = GetCenterByName(univerName).SelectMany(x => x.Students).Where(z => z.Grant == false);

            return result;
        }
    }
}
