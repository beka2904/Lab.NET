using System.Collections.Generic;
using tut1.Models;

namespace tut1
{
    public class Database
    {

        private Database() { }
        public static Database shared = new Database();

        public List<Student> students
        {
            get
            {
                List<Student> students = new List<Student>();
                students.Add(new Student("Beknazar", "29-04-2000", "CSSE-1703K"));
                students.Add(new Student("Shadiyar", "02-05-2000", "CSSE-1703K"));
                students.Add(new Student("Daulet", "14-09-1999", "CSSE-1703K"));
                students.Add(new Student("Jarkyn", "19-02-1999", "CSSE-1703K"));
                students.Add(new Student("Adilet", "12-03-2000", "CSSE-1703K"));
                students.Add(new Student("Rahataly", "22-08-1999", "CSSE-1703K"));
                students.Add(new Student("Zhanbolat", "01-06-2000", "CSSE-1703K"));
                students.Add(new Student("Mirzhan", "23-03-2000", "CSSE-1703K"));
                students.Add(new Student("Nurzhan", "30-03-2000", "CSSE-1703K"));
                students.Add(new Student("Adil", "20-01-2000", "CSSE-1703K"));
                students.Add(new Student("Zhassulan", "31-01-2000", "CSSE-1703K"));
                return students;
            }
        }
    }
}