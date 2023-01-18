namespace Use_IComparable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var students = new Student[5];
            students[0] = new Student("Meet", "Kerasiya" );
            students[1] = new Student("Krupal", "Vasani");
            students[2] = new Student("Mitesh", "Kateliya");
            students[3] = new Student("Jay", "Laheri");
            students[4] = new Student("Bhayubha", "Sisodiya");

            Array.Sort(students);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

    }
    public class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstName,string lastName)
        {
            FirstName= firstName;
            LastName= lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        public int CompareTo(object? obj)
        {
            if(obj == null) return 1 ;
            if(obj is Student someStudent)
            {
                if(someStudent.FirstName == this.FirstName)
                {
                    return this.LastName.CompareTo(someStudent.LastName);
                }
                return this.FirstName.CompareTo(someStudent.FirstName);
            }
            throw new ArgumentException("Not a Student", nameof(obj));
        }
     
    }
}