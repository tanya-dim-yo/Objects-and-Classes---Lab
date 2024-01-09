namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (info != "end")
            {
                string[] infoArray = info.Split();

                string firstName = infoArray[0];
                string lastName = infoArray[1];
                int age = int.Parse(infoArray[2]);
                string town = infoArray[3];

                bool studentExist = false;

                foreach (var student in students)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        student.Age = age;
                        student.HomeTown = town;
                        studentExist = true;
                        break;
                    }
                }

                if (!studentExist)
                {
                    Student student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = town
                    };

                    students.Add(student);
                }

                info = Console.ReadLine();
            }

            string homeTown = Console.ReadLine();

            foreach (Student currentStudent in students)
            {
                if (currentStudent.HomeTown == homeTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}