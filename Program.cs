using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw220722
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = Uchastniki.howManyPeople("Введите кол-во участников: ");
            List<Uchastniki> uchastniki = new List<Uchastniki>();
            for (int i = 0; i < count; i++)
            {
                uchastniki.Add(new Uchastniki(i + 1));
            }
            void vyvod()
            {
                Console.WriteLine("Все участники: ");
                foreach (var item in uchastniki)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("[1] Добавить участника\n[2] Удалить участника\n[3]Изменить возраст\n[4]Изменить имя");
            switch (Console.ReadLine())
            {
                case "1":
                    uchastniki.Add(new Uchastniki(uchastniki.Count + 1)); vyvod(); 
                    break;
                case "2":
                    uchastniki.RemoveAt(Uchastniki.howManyPeople("") - 1);
                    vyvod(); 
                    break;
                case "3":
                    {
                        vyvod();
                        Console.WriteLine("Введите ID участника: ");
                        int age = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите новый возраст: ");
                        uchastniki.ElementAt(age).Age = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        vyvod();
                        break;
                    }
                case "4":
                    {
                        vyvod();
                        Console.WriteLine("Введите ID участника: ");
                        int name = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите новое Имя: ");
                        uchastniki.ElementAt(name).Name = String.Format(Console.ReadLine());
                        Console.WriteLine();
                        vyvod();
                        break;
                    }
                default:
                    {
                        Console.WriteLine();
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
