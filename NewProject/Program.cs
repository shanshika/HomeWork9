using NewProject;
using System;
using System.Dynamic;
using System.IO.Pipes;
using System.Net;
using System.Net.Cache;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;
using System.Xml.Linq;

namespace NewOneHomeWork
{
    //1. შექმენით ორი დამოუკიდებელი კლასი(Parent, child). Parent კლასში დაწერეთ მეთოდი,
    // რომელიც გამოითვლის კონსოლიდან შეყვანილი რიცხვების ნამრავლს.
    // Child კლასს მემკვიდრეობით უნდა გამოეცეს ეს მეთოდი. კონსოლზე გამოიტანეთ შესაბამისი მნიშნელობა.

    class Parent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Numb1:");
            int Numb1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Numb2:");
            int Numb2 = Int32.Parse(Console.ReadLine());

            int Multip = Numb1 * Numb2;

            Console.WriteLine("Your Multip: " + " " + Multip);
            Console.ReadLine();

            
        }

        public int Numb1 { get; set; }
        public int Numb2 { get; set; }
        public int Multip { get; set; }
       
    }

    class Child : Parent
    {
        static int Multiplic()
        {
            Parent Par = new Parent();
            return Multiplic();
        }
    }


    //3.შექმენით სამი კლასი, სამი ობიექტი. ყველას უნდა ჰქონდეს ერთი საერთო მახასიათებელი პ/ნ და რაიმე უნიკალური კოდი,
    //რომელსაც მიღებენ მშობელი კლასიდან. თავის მხრივ ამ კლასებს უნდა ჰქონდეთ განსხვავებული ველები: პირველ კლასს სახელი და მისამართი,
    //მეორე კლასს ასაკი და დაბადების თარიღი, მესამე კლასს ქვეყანა და ქალაქი. კონსოლზე გამოიტანეთ დაწყვილებული ინფორმაცია, პირველი კლასის ცალკე,
    //მეორესი ცალკე და ა.შ.
    public class Person: FirstNameAdress
    {             
        public Person(string GetAdress, int GetDate, string GetCountry)
        {
           
            Console.WriteLine($"Name and Adress : {GetAdress} \n  DateBirth : {GetDate} \n Country and Town: {GetCountry}");
            Console.ReadLine();

        }

    }
}


