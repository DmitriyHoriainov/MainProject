using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, double> dict = new Dictionary<string, double>();
            Console.WriteLine("ВВедите количество учеников");
            int k = Convert.ToInt32(Console.ReadLine());
          

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("ВВедите имя ученика или фамилию");
                string name = Console.ReadLine();
                double a, b, d;
                Console.WriteLine("Введите оценку 1");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите оценку 2");
                b = Convert.ToDouble(Console.ReadLine());

                d = (a + b) / 2;
                dict.Add(name, d);
                Console.Clear();
            }

            dict = dict.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var item in dict)
                Console.WriteLine(item.Key + " " + item.Value);
            Console.Read();

        }
    }
}
