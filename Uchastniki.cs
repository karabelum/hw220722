using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw220722
{
    class Uchastniki
    {
        public Uchastniki (int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Uchastniki(int id)
        {
            Id = id;
            Name = vod("Введите Имя участника:  ");
            Age = howManyPeople("Введите возраст участника:  ");
        }
        string vod(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
        public static int howManyPeople(string text)
        {
            try
            {
                Console.Write(text);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("что то пошло не так");
                return howManyPeople(text);
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"ID Участника: {Id} \nИмя: {Name}\nВозраст: {Age}\n";
        }
    }
}
