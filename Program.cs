using System;
using LB_2.classes;

namespace LB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания");
            int number = Convert.ToInt32(Console.ReadLine());

            switch(number)
            {
                case 1:
                    {
                        #region 1-task
                        Address address = new Address() { Index = 100, Country = "Ukraine", City = "Kyiv", Street = "Lobachevsky", House = 23, Apartment = 410 };
                        Console.WriteLine($"{address.Index} {address.Country} {address.City} {address.Street} {address.House} {address.Apartment}");
                        #endregion
                    }
                    break;
                case 2:
                    {
                        #region 2-task
                        Console.WriteLine("Введите 1-ю сторону прямоугольника");
                        double side1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите 2-ю сторону прямоугольника");
                        double side2 = Convert.ToInt32(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(side1,side2);

                        Console.WriteLine("периметр прямоугольника");
                        Console.WriteLine(rectangle.Perimeter);
                        Console.WriteLine("Площадь прямоугольника");
                        Console.WriteLine(rectangle.Area);
                        #endregion
                    }
                    break;
                case 3:
                    {
                        #region
                        Book book = new Book(
                            new Title("React и Redux: функциональная веб-разработка"),
                            new Author("Бэнкс А., Порселло Е"),
                            new Content("Как создавать пользовательские интерфейсы при помощи этой компактной библиотеки и писать сайты," +
                            " на которых можно обрабатывать огромные объемы данных без перезагрузки страниц")
                            );
                        book.Show();
                        #endregion
                    }
                    break;
                case 4:
                    {
                        #region
                        {
                            Point A = new Point(0, 3, "A");
                            Point B = new Point(2, 0, "B");
                            Point C = new Point(0, 0, "C");
                            Figure figure = new Figure(A, B, C);
                            Console.WriteLine($"Название фигуры: {figure.Name}");
                            figure.PerimeterCalculator();
                        }
                        #endregion
                    }
                    break;
                case 5:
                    {
                        #region
                        Console.WriteLine("Ваш логин:");
                        string login = Console.ReadLine();
                        Console.WriteLine("Ваше имя:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ваше фамилия:");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Ваш возраст:");
                        int age = Convert.ToInt32(Console.ReadLine());

                        User user = new User(login, name, surname, age);

                        user.displayUserInfo();
                        #endregion
                    }
                    break;
                case 6:
                    {
                        #region
                        Converter converter = new Converter(0.035, 0.030, 3.7);
                        converter.convertFromUAH();
                        converter.convertToUAH();
                        #endregion
                    }
                    break;
                case 7:
                    {
                        #region
                        Employee employee = new Employee("Иван", "Иванов");
                        employee.GetInfo();
                        #endregion
                    }
                    break;
                case 8:
                    {
                        #region 8-е Задание
                        Invoice invoice = new Invoice(16847, "Тарас", "IBM");
                        invoice.Price();
                        #endregion  
                        break;
                    }
                default:
                    Console.WriteLine("Введите другую цифру");
                    return;
            }
        }
    }
}
