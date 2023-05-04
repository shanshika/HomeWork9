using NewOneHomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    //2.შექმენით ერთი კლასი, რომელიც მემკვიდრეობით მიღებს ორ ველს: თქვენს სახელს და მისამართს. თავის მხრივ,
    //ამ კლასს უნდა ჰქონდეს ორი ველი დაბადების თარიღი და ასაკი. შედეგები გამოიტანეთ კონსოლზე.

  public class DateBirth : FirstNameAdress
  {
        public int Date { get; set; }
        public int Age { get; set; }
        public void GetDate(int date, int age)
        {
            Date = date;
            date = 20 / 02 / 1989;
             Age = age;
            age = 34;
        }

  }
}
