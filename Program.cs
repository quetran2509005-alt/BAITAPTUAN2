using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Student> students = new List<Student>()
        {
            new Student(1, "HA", 14),
            new Student(2, "An", 17),
            new Student(3, "Binh", 18),
            new Student(4, "Anh Tu", 16),
            new Student(5, "Quang", 19)
        };

            // a. In toàn bộ danh sách học sinh
            Console.WriteLine("a. Danh sách toàn bộ học sinh:");
            students.ForEach(s => s.Info());
            Console.WriteLine();

            // b. Học sinh có tuổi từ 15 đến 18
            Console.WriteLine("b. Học sinh có tuổi từ 15 đến 18:");
            var from15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var s in from15to18) s.Info();
            Console.WriteLine();

            // c. Học sinh tên bắt đầu bằng chữ “A”
            Console.WriteLine("c. Học sinh có tên bắt đầu bằng 'A':");
            var startWithA = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            foreach (var s in startWithA) s.Info();
            Console.WriteLine();

            // d. Tổng tuổi của tất cả học sinh
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine("d. Tổng tuổi của tất cả học sinh: " + totalAge);
            Console.WriteLine();

            // e. Học sinh có tuổi lớn nhất
            int maxAge = students.Max(s => s.Age);
            Console.WriteLine("e. Học sinh có tuổi lớn nhất:");
            var oldest = students.Where(s => s.Age == maxAge);
            foreach (var s in oldest) s.Info();
            Console.WriteLine();

            // f. Sắp xếp danh sách theo tuổi tăng dần
            Console.WriteLine("f. Sắp xếp học sinh theo tuổi tăng dần:");
            var sorted = students.OrderBy(s => s.Age);
            foreach (var s in sorted) s.Info();

        }
    }
}
