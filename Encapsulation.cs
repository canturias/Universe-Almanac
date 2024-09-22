using System;

namespace Encapsulation
{
    class Student {
        public string Name { get; private set; }


        public Student(string _name) {
            if (string.IsNullOrWhiteSpace(_name)) {
                throw new ArgumentException("The name cannot be empty.", nameof(_name));
            }
            Name = _name;
        }
    }

    class Program {
        public static void FakeMain() {
            Student student1 = new Student("Chris");


        }
    }
}