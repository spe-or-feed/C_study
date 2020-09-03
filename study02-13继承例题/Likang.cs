using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace study02_13继承例题
{
    class Likang:Person
    {
        public Likang(string name, int age, string hobby,string work)
        : base(name, age, hobby)
    {
            this.Work = work;
    }
        private string work;

        public string Work { get => work; set => work = value; }
        public void LikangSay()
        {
            Console.WriteLine("{0}{1}", this.Name, this.Age);
        }
    }
}
