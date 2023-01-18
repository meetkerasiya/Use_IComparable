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
            Console.WriteLine();
            var authors = new Author[5];
            for (int i =0;i<authors.Length;i++)
            {
                authors[i]= new Author(students[i].FirstName, students[i].LastName);
            }
            Array.Sort(authors);
            foreach(var author in authors)
            {
                Console.WriteLine(author);
            }
        }

    }

   
    public class Author : IComparable<Author>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
       /* public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            if (obj is Author someAuthor)
            {
                if (someAuthor.FirstName == this.FirstName)
                {
                    return this.LastName.CompareTo(someAuthor.LastName);
                }
                return this.FirstName.CompareTo(someAuthor.FirstName);
            }
            throw new ArgumentException("Not a Author", nameof(obj));
        }
       */
        public int CompareTo(Author? other)
        {
            if (!(other is Author)) return 1;
            if (other.FirstName == this.FirstName)
            {
                return this.LastName.CompareTo(other.LastName);
                
            }
            return this.FirstName.CompareTo(other.FirstName);
        }
        
    }
    public class Student : IComparable<Student>
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
        /*
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
        */
        public int CompareTo(Student? other)
        {
            if(!(other is Student)) return 1 ;  
            if(other.LastName==this.LastName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            return this.LastName.CompareTo(other.LastName);
        }
    }
}