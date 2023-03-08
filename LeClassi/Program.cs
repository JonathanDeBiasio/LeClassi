using System;

namespace LeClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Jonathan",23);
            Person.fondoComune = 1000.00M;
            Person person2 = new Person("Carlo", 30);
            person2.GetName();
            Console.WriteLine(Person.fondoComune);
            Console.WriteLine("adding more value....");
            Person.fondoComune += 1000.00M;
            
            Console.WriteLine(Person.getFondoComune());
        }
    }

    internal class Person
    {
       public static decimal fondoComune;
         string _name;
         int _age;

        public Person(string Name, int Age)//firma del costruttore
        {
            _name = Name;
            _age = Age;
        }

        public string GetName()
        {
            return _name;
        }
        
        public static decimal getFondoComune() 
        {
        }
    }
}
