using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGrammarExample
{
    class Person
    {
        private string name;
        private string age;

        public Person(string name, string age)
        {
            this.name = name;
            this.age = age;
        }
        public void InfoPerson()
        {
            Console.WriteLine($"{name}의 나이는 {age}입니다.");
        }
    }
}
