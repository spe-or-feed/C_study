using System;
using System.Collections.Generic;
using System.Text;

namespace study02_13继承例题
{
    class Kangkang:Person
    {
        public Kangkang(string name,int age,string hobby,string food) 
            :base(name, age, hobby)
        {
            this.Food = food;
        }
            private string _food;

        public string Food { get => _food; set => _food = value; }
        public void KangknagSay()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，我爱{2}，我最喜欢的食物是{3}", this.Name, this.Age, this.Hobby, this.Food);
        }
    }
}
