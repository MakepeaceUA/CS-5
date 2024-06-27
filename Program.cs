using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp7
{
    
    internal class Program
    {          //Задание 1
               //    public enum ClientType
               //    {
               //        Regular,   
               //        Silver,     
               //        Gold,
               //        Diamond
               //    }

        //    public struct Client
        //    {
        //        int ID;
        //        string Name;
        //        string Address;
        //        string Phone;
        //        int Order;
        //        int OrderSum;
        //        ClientType ClientImportance;

        //        public Client(int id, string n, string a, string p, int o, int os, ClientType ci)
        //        {
        //            ID = id;
        //            Name = n;
        //            Address = a;
        //            Phone = p;
        //            Order = o;
        //            OrderSum = os;
        //            ClientImportance = ci;
        //        }
        //        public void Print()
        //        {
        //            Console.WriteLine("Код клиента: " + ID);
        //            Console.WriteLine("ФИО: " + Name);
        //            Console.WriteLine("Адрес: " + Address);
        //            Console.WriteLine("Телефон: " + Phone);
        //            Console.WriteLine("Количество заказов: " + Order);
        //            Console.WriteLine("Общая сумма заказов: " + OrderSum);
        //            Console.WriteLine("Важность клиента: " + ClientImportance);
        //        }
        //    }

        //Задание 2
        //public class RangeSum
        //{
        //    public int SumRange(int start, int end)
        //    {
        //        int sum = 0;
        //        for (int i = start; i <= end; i++)
        //        {
        //            sum += i;
        //        }
        //        return sum;
        //    }
        //}

        // Задание 3
        //class Airplane
        //{
        //    string name;
        //    string manufacturer;
        //    int year;
        //    string type;

        //    public Airplane(string n, string m, int y, string a)
        //    {
        //        name = n;
        //        manufacturer = m;
        //        year = y;
        //        type = a;
        //    }
        //    public string GetName()
        //    {
        //        return name;
        //    }
        //    public void SetName(string value)
        //    {
        //        name = value;
        //    }
        //    public string GetManufacturer()
        //    {
        //        return manufacturer;
        //    }
        //    public void SetManufacturer(string value)
        //    {
        //        manufacturer = value;
        //    }
        //    public int GetYear()
        //    {
        //        return year;
        //    }
        //    public void SetYear(int value)
        //    {
        //        year = value;
        //    }
        //    public string GetType()
        //    {
        //        return type;
        //    }
        //    public void SetType(string value)
        //    {
        //        type = value;
        //    }

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //public string Manufacturer
        //{
        //    get { return manufacturer; }
        //    set { manufacturer = value; }
        //}
        //public int Year
        //{
        //    get { return year; }
        //    set { year = value; }
        //}
        //public string Type
        //{
        //    get { return type; }
        //    set { type = value; }
        //}


        //public string AutoName { get; set; }
        //public string AutoManufacturer { get; set; }
        //public int AutoYear { get; set; }
        //public string AutoType { get; set; }

        //public void Print()
        //{
        //    Console.WriteLine($"Name: {name}");
        //    Console.WriteLine($"Manufacturer: {manufacturer}");
        //    Console.WriteLine($"Year: {year}");
        //    Console.WriteLine($"Type: {type}");
        //}
        //}


        // Задание 4
        //public class Journal
        //{
        //    string name;
        //    int year;
        //    string description;
        //    string phone;
        //    string email;

        //    public Journal()
        //    {
        //        name = "";
        //        year = 0;
        //        description = "";
        //        phone = "";
        //        email = "";
        //    }

        //    public string Name
        //    {
        //        get { return name; }
        //        set { name = value; }
        //    }

        //    public int Year
        //    {
        //        get { return year; }
        //        set { year = value; }
        //    }

        //    public string Description
        //    {
        //        get { return description; }
        //        set { description = value; }
        //    }

        //    public string Phone
        //    {
        //        get { return phone; }
        //        set { phone = value; }
        //    }

        //    public string Email
        //    {
        //        get { return email; }
        //        set { email = value; }
        //    }
        //    public void Input()
        //    {
        //        Console.Write("Введите название журнала: ");
        //        Name = Console.ReadLine();
        //        Console.Write("Введите год основания: ");
        //        Year = Convert.ToInt32(Console.ReadLine());
        //        Console.Write("Введите описание журнала: ");
        //        Description = Console.ReadLine();
        //        Console.Write("Введите контактный телефон: ");
        //        Phone = Console.ReadLine();
        //        Console.Write("Введите контактный e-mail: ");
        //        Email = Console.ReadLine();
        //    }

        //    public void Print()
        //    {
        //        Console.WriteLine("Название журнала: " + Name);
        //        Console.WriteLine("Год основания: " + Year);
        //        Console.WriteLine("Описание журнала: " + Description);
        //        Console.WriteLine("Контактный телефон: " + Phone);
        //        Console.WriteLine("Контактный e-mail: " + Email);
        //    }
        //}




        static void Main(string[] args)
        {
            //Client obj = new Client(123, "ФИО", "Улица", "+3800000", 5, 5000, ClientType.Diamond);
            //obj.Print();

            
            
            //RangeSum obj1 = new RangeSum();
            //int res = obj1.SumRange(1, 100);
            //Console.WriteLine("Сумма:" + res);


            
            //Airplane obj = new Airplane("Самолёт", "Производитель", 2000, "Тип");
            //Console.WriteLine(obj.GetName());
            //Console.WriteLine(obj.GetManufacturer());
            //Console.WriteLine(obj.GetYear());
            //Console.WriteLine(obj.GetType());

            
            
            
            //Journal obj2 = new Journal();
            //obj2.Input();
            //obj2.Print();

        }
    }
}
