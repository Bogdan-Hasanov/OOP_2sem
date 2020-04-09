using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2sem
{
    class Student : IComparable
    {
        public string Name { get; set; }
        public string TestName { get; set; }
        public string Date { get; set; }
        public short Mark { get; set; }

        public Student()
        {
        }

        public Student(short mark=default, string name="", string testName="", string date="") : base()
        {
            Name = name;
            TestName = testName;
            Date = date;
            Mark = mark;
        }

        public int CompareTo(object obj)
        {
            Student student = (Student) obj;
            if (student != null)
                return this.Mark.CompareTo(student.Mark);
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Name = {Name}, Test = {TestName}, Date = {Date}, Mark = {Mark}";
        }
    }
}