using System;

namespace Inheritance
{
    class Person {
        public string Name { get; set; }
    }

    class Student : Person{
        public double GPA { get; set; }
    }

    class Worker : Person{
        public double Salary { get; set; }
    }
}