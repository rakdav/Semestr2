using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public delegate void ExamDelegete(string t);
    public class Teacher
    {
        public event ExamDelegete? examEvent;
        public void Exam(string t)
        {
            if (examEvent != null)
            {
                examEvent(t);
            }
        }
    }
}
