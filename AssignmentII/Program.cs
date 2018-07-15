using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentII
{
    public class Program
    {
        public abstract class Person
        {
            public Person()
            {
            }
            public Person(string name)
            {
                this.Name = name;
            }

            public string Name { get; set; }

            public string getName()
            {
                return this.Name;
            }

            public void setName(string name)
            {
                this.Name = name;
            }

            abstract public bool isOutstanding();
        }

        public class Professor : Person
        {
            public Professor() { }
            public Professor(string name, int bookPublished)
            {
                this.Name = name;
                this.bookPublished = bookPublished;
            }
            public int bookPublished { get; set; }
            public void print()
            {
                Console.WriteLine("Name {0}", Name);
                Console.WriteLine("Books Published {0}", bookPublished);
            }
            public override bool isOutstanding()
            {
                return this.bookPublished > 4 ? true : false;
            }
        }

        public class Student : Person
        {
            public Student() { }
            public Student(string name, double percentage)
            {
                this.Name = name;
                this.percentage = percentage;
            }

            public double percentage { get; set; }
            public void display()
            {
                Console.WriteLine("Name {0}", Name);
                Console.WriteLine("Percentage {0}", percentage);
            }
            public override bool isOutstanding()
            {
                return this.percentage > 85 ? true : false;
            }
        }

        public static void Main()
        {
            try
            {
                Person[] persons = new Person[5];
                persons[0] = new Student("Alex", 90.2);
                persons[1] = new Student("Bobalan", 80);
                persons[2] = new Student("Dolton", 95);
                persons[3] = new Professor("Mr. Sharelok",52); 
                persons[4] = new Student("Mr. Watson",3);

                foreach (var person in persons) 
                {
                    if (person.isOutstanding()) 
                    {
                        if (person is Student)
                        {
                            ((Student)person).display();
                        }
                        else 
                        {
                            ((Professor)person).print();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}