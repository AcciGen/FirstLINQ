using FirstLINQ.LINQMethods;

namespace FirstLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LINQForUniversities data = new LINQForUniversities();
            //foreach (var item in data.GetCenterByName("Najot Ta'lim"))
            //{
            //    var empoyees = item.Employees.Select(x => x).Where(z => z.Experience > 5);
            //    Console.WriteLine(item.Name);
            //    foreach(var employee in empoyees)
            //    {
            //        Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //    }
            //}

            foreach (var item in data.GetStudentByGrantWithUniversity("PDP"))
            {
                Console.WriteLine(item.FirstName + " " + item.Grant);
            }
        }
    }
}
