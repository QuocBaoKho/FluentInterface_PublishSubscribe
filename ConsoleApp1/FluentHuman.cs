using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FluentHuman
    {
        Human human = new Human();
        public FluentHuman TheirNameIs(string name)
        {
            human.Name = name;
            return this;
        }
        public FluentHuman AgeOfThem(int age)
        {
            human.Age = age;
            return this;
        }
        public FluentHuman LivesIn(string nationality)
        {
            human.Nationality = nationality;
            return this;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Name: {human.Name}\nAge: {human.Age}\nNationality: {human.Nationality}");
        }
    }
}
