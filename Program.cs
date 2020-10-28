using System;

namespace LAB_4_2
{
    class A
    {
        B b1;
        B b2;
        B b3;
        public A() { }
        public A(B b1, B b2, B b3)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }
        public A(B b1, B b2) : this(b1, b2, null) { }
        public void About()
        {
            if (b3 == null)
            {
                Console.WriteLine($"Name- {b1.Name}\nAge - {b1.Age}\nSalary - {b1.Salary}");
                Console.WriteLine($"Name- {b2.Name}\nAge - {b2.Age}\nSalary - {b2.Salary}");
            }
            else
            {
                Console.WriteLine($"Name- {b1.Name}\nAge - {b1.Age}\nSalary - {b1.Salary}");
                Console.WriteLine($"Name- {b2.Name}\nAge - {b2.Age}\nSalary - {b2.Salary}");
                Console.WriteLine($"Name- {b3.Name}\nAge - {b3.Age}\nSalary - {b3.Salary}");
            }
        }
    }
    class B
    {
        private int _age;
        private string _name;
        private int _salary;
        public int Age { get { return _age; } set { _age = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Salary { get { return _salary; } set { _salary = value; } }
        public B() { }
        public B(int age, string name, int salary)
        {
            this.Age = age;
            this.Name = name;
            this.Salary = salary;
        }
        public virtual void DisplayAge()
        {
            Console.WriteLine($"{this.Age}");
        }
        public virtual void DisplayName()
        {
            Console.WriteLine($"{this.Name}");
        }
        public virtual void DisplaySalary()
        {
            Console.WriteLine($"{this.Salary}");
        }
    }
    class B1 : B
    {
        public B1(int age, string name, int salary) : base(age, name, salary) { }
        public override void DisplayAge()
        {
            Console.WriteLine($"Age is {this.Age}");
        }
    }
    class B2 : B
    {
        public B2(int age, string name, int salary) : base(age, name, salary) { }
        public override void DisplayName()
        {
            Console.WriteLine($"Name is {this.Name}");
        }
    }
    class B3 : B
    {
        public B3(int age, string name, int salary) : base(age, name, salary) { }
        public override void DisplaySalary()
        {
            Console.WriteLine($"Salary is {this.Salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B worker1 = new B(18, "Kozlov", 13000);
            B worker2 = new B(19, "Artem", 130400);
            B worker3 = new B(20, "Lebedev", 130000);
            A a1 = new A(worker1, worker2, worker3);
            a1.About();
            A a2 = new A(worker1, worker3);
            worker1.DisplayAge();

            B1 bb1 = new B1(worker1.Age, worker1.Name, worker1.Salary);
            bb1.DisplayAge();

            B2 bb2 = new B2(worker2.Age, worker2.Name, worker2.Salary);
            bb2.DisplayName();
        }
    }

}
