using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СТО_ЛОТО
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше Имя");
            string name = Console.ReadLine();


            Console.WriteLine("сколько вам лет?");
            int Let = Convert.ToInt32(Console.ReadLine());

            if (Let <= 16)

            {
                Console.WriteLine($"Добрый день {name}, для данной игры, надо чтобы вам было не менее 16 лет (Азартные игры дело плохое)");
                Console.ReadLine();
            }

            else if (Let >= 17)
            {
                Console.WriteLine($"Добрый день {name}, пожалуй начнем) ");
                Console.WriteLine($"Для начало введите 5 цифр от 1 до 25 ");
                int A = Convert.ToInt32(Console.ReadLine()); // 1 цифра
                int B = Convert.ToInt32(Console.ReadLine()); // 2 цифра
                int C = Convert.ToInt32(Console.ReadLine()); // 3 цифра
                int D = Convert.ToInt32(Console.ReadLine()); // 4 цифра
                int E = Convert.ToInt32(Console.ReadLine()); // 5 цифра
                

         
                Console.WriteLine($"Подождите идет загрузка");
                for (int x = 1; x <= 1000; x++)
                { Console.WriteLine($"{x} %"); }
          
                
                Console.Clear();
                Console.WriteLine($"{name} вы можете ознакомится с результатами ");
                Console.WriteLine($"");

                Random rand = new Random();  // 1 Уровень
                int i = rand.Next(25);
                int count = 1;
                while (count <= 3)
                {
                    if (i == A)
                    {
                        Console.WriteLine("Вы отгодали, чило было " + i + "!");
                        break;
                    }
                    else
                    {
                        count++;
                        if (count == 4)
                        {
                            Console.WriteLine("Вы не отгодали, чило было " + i + "!");
                            break;
                        }

                    }
                }

                Random r = new Random();   // 2 Уровень
                int hh = rand.Next(25);
                int ben = 1;
                while (ben <= 3)
                {
                    if (hh == B)
                    {
                        Console.WriteLine("Вы отгодали, чило было " + hh + "!");
                        break;
                    }
                    else
                    {
                        ben++;
                        if (ben == 4)
                        {
                            Console.WriteLine("Вы не отгодали, чило было " + hh + "!");
                            break;
                        }

                    }
                }

                Random rfd = new Random();  // 3 Уровень
                int hhg = rand.Next(25);
                int be = 1;
                while (be <= 3)
                {
                    if (hhg == C)
                    {
                        Console.WriteLine("Вы отгодали, чило было " + hhg + "!");
                        break;
                    }
                    else
                    {
                        be++;
                        if (be == 4)
                        {
                            Console.WriteLine("Вы не отгодали, чило было " + hhg + "!");
                            break;
                        }

                    }
                }

                Random rfdr = new Random();  // 4 Уровень
                int hhgg = rand.Next(25);
                int bee = 1;
                while (bee <= 3)
                {
                    if (hhg == D)
                    {
                        Console.WriteLine("Вы отгодали, чило было " + hhgg + "!");
                        break;
                    }
                    else
                    {
                        bee++;
                        if (bee == 4)
                        {
                            Console.WriteLine("Вы не отгодали, чило было " + hhgg + "!");
                            break;
                        }

                    }
                }

                Random rfdet = new Random(); // 5 Уровень
                int hhgek = rand.Next(25);
                int beru = 1;
                while (beru <= 3)
                {
                    if (hhg == E)
                    {
                        Console.WriteLine("Вы отгодали, чило было " + hhgek + "!");
                        break;
                    }
                    else
                    {
                        beru++;
                        if (beru == 4)
                        {
                            Console.WriteLine("Вы не отгодали, чило было " + hhgek + "!");
                            break;
                        }

                    }
                }
                Console.WriteLine($"  ");
                Console.WriteLine($"Ваши числа ");
                Console.WriteLine($"{A} ");
                Console.WriteLine($"{B}");
                Console.WriteLine($"{C} ");
                Console.WriteLine($"{D} ");
                Console.WriteLine($"{E} ");
                Console.WriteLine($"");
                Console.WriteLine($"Вы можете сравнить результы выйгрыша");
                Console.WriteLine($"Всего отгодали 1 число угодали 100 баллов");
                Console.WriteLine($"Всего отгодали 2 число угодали 500 баллов");
                Console.WriteLine($"Всего отгодали 3 число угодали 1000 баллов");
                Console.WriteLine($"Всего отгодали 4 число угодали 10000 баллов");
                Console.WriteLine($"Всего отгодали 5 число угодали 500000 баллов");
                Console.ReadLine();
            }
        }
    }
}
