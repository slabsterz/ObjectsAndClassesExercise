namespace Students
{
    public class Program
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

        }

        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            int cycles = int.Parse(Console.ReadLine());

            for (int i = 0; i < cycles; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student(firstName, lastName, grade);

                studentsList.Add(student);
            }

            List<Student> sortedStudentList = studentsList.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in sortedStudentList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}