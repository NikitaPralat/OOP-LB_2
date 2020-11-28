using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class User
    {
        string login;
        string name;
        string surname;
        int age;
        string date;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        public void displayUserInfo()
        {
            Console.WriteLine($"логин: {login}");
            Console.WriteLine($"имя: {name}");
            Console.WriteLine($"фамилие: {surname}");
            Console.WriteLine($"возраст: {age}");
            Console.WriteLine($"дата заполнения анкеты: {date}");
        }
    }
}
