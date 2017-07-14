using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture01
{
    internal class program
    {
        private static void Main(string[] args)
        {
        }
    }

    public class Student
    {
        public string name;
        public string phone;
        public string address;

        private Student astudent = new Student()
        {
            name = "葉凱安",
            phone = "0925152416",
            address = "台大資工"
        };
    }
}