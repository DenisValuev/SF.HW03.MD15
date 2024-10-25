using SF.HW03.MD15.Models;

internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
                new Classroom { Students = { "Evgeniy", "Sergey", "Andrew"} },
                new Classroom { Students = { "Anna", "Viktor", "Vladimir" } },
                new Classroom { Students = { "Bulat", "Alex", "Galina" } },
            };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        /// <summary>
        /// Собирает всех учеников классов в один список
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(c => c.Students).ToArray();
        }
    }
