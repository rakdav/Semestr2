using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Student
    {
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate {  get; set; }
        public void Exam(string task)
        {
            Console.WriteLine($"Студент {LastName} сдал {task}");
        }

    }
}
