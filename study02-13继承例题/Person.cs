using System;
using System.Collections.Generic;
using System.Text;

namespace study02_13继承例题
{
    class Person
    {
        public Person(string name, int age, string hobby)
        {
            this.Name = name;
            this.Age = age;
            this.Hobby = hobby;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        
        private int _age;
        public int Age { get => _age; set => _age = value; }
        private string _hobby;
        public string Hobby { get => _hobby; set => _hobby = value; }
        
    }
}
