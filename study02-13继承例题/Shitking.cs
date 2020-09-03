using System;
using System.Collections.Generic;
using System.Text;

namespace study02_13继承例题
{
    class Shitking : Person
    {
        public Shitking(string name, int age, string hobby, string work)
            : base(name, age, hobby)
        {
            this.Work = _work;

        }
        private string _work;
        public string Work
        { get => _work; set => _work = value; }

        public void ShitkingSayhi()
        {
            Console.WriteLine("{0},{1},{2},{3}", this.Name, this.Age, this.Work, this.Hobby);
            }
    }
    }
