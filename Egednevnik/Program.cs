using Egednevnik;

internal class Programm

{
    static void Main()
    {
          while (true)
          {
            DateTime Date = DateTime.Now;
            int pos = 2;
            ConsoleKeyInfo key;

            do
            {
                if (Date.Date == new DateTime(2023, 10, 17))
                {
                    Console.Clear();
                    Console.WriteLine(Date);
                    Console.WriteLine("  Задачи на сегодня:");
                    Console.WriteLine("  1.Встать");
                    Console.WriteLine("  2.Поесть");
                    Console.WriteLine("  3.Лечь спать");
                }
                else if (Date.Date == new DateTime(2023, 10, 18))
                {
                    Console.Clear();
                    Console.WriteLine(Date);
                    Console.WriteLine("  Задачи на сегодня:");
                    Console.WriteLine("  1.Сходить в шарагу");
                }
                else if (Date.Date == new DateTime(2023, 10, 16))
                {
                    Console.Clear();
                    Console.WriteLine(Date);
                    Console.WriteLine("  Задачи на сегодня:");
                    Console.WriteLine("  1.Поиграть В КС");
                }
                else if (Date.Date != new DateTime(2023, 10, 18))
                {
                    Console.Clear();
                    Console.WriteLine(Date);
                }
                else if (Date.Date != new DateTime(2023, 10, 17))
                {
                    Console.Clear();
                    Console.WriteLine(Date);
                }
                else if (Date.Date != new DateTime(2023, 10, 16))
                {
                    Console.Clear();
                    Console.WriteLine(Date);
                }




                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != 2)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != 4)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Date = Date.AddDays(-1);

                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(Date);
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    Date = Date.AddDays(1);

                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(Date);
                }





            }
                while (key.Key != ConsoleKey.Enter) ;

            if (pos == 2 && Date.Date == new DateTime(2023, 10, 17))
            {
                Console.Clear();
                Day1 wake = new Day1();
                wake.data = Date;
                wake.title = "Встать";
                wake.zachem = "Нужно вставать";
                wake.vremya = "К 10";
                Console.WriteLine(wake.data);
                Console.WriteLine(wake.title);
                Console.WriteLine(wake.zachem);
                Console.WriteLine(wake.vremya);
            }
            else if (pos == 2 && Date.Date == new DateTime(2023, 10, 18))
            {
                Console.Clear();
                Day1 sharaga = new Day1();
                sharaga.data = Date;
                sharaga.title = "Сходить в шарагу";
                sharaga.zachem = "Сегодня 4 пары";
                sharaga.vremya = "К 8";
                Console.WriteLine(sharaga.data);
                Console.WriteLine(sharaga.title);
                Console.WriteLine(sharaga.zachem);
                Console.WriteLine(sharaga.vremya);
            }
            else if (pos == 2 && Date.Date == new DateTime(2023, 10, 16))
            {
                Console.Clear();
                Day1 KS = new Day1();
                KS.data = Date;
                KS.title = "Поиграть в КС";
                KS.zachem = "Повысить звание";
                KS.vremya = "К 8";
                Console.WriteLine(KS.data);
                Console.WriteLine(KS.title);
                Console.WriteLine(KS.zachem);
                Console.WriteLine(KS.vremya);
            }

            else if (pos == 3 && Date.Date == new DateTime(2023, 10, 17))
            {
                Console.Clear();
                Day1 eat = new Day1();
                eat.data = (Date);
                eat.title = "Поесть";
                eat.zachem = "Нужно поесть";
                eat.vremya = "К 12";
                Console.WriteLine(eat.data);
                Console.WriteLine(eat.title);
                Console.WriteLine(eat.zachem);
                Console.WriteLine(eat.vremya);
            }
            else if (pos == 4 && Date.Date == new DateTime(2023, 10, 17))
            {
                Console.Clear();
                Day1 sleep = new Day1();
                sleep.data = (Date);
                sleep.title = "Поспать";
                sleep.zachem = "Нужно поспать";
                sleep.vremya = "к 20";
                Console.WriteLine(sleep.data);
                Console.WriteLine(sleep.title);
                Console.WriteLine(sleep.zachem);
                Console.WriteLine(sleep.vremya);
            }
                Console.ReadKey();
                Console.Clear();
          }

         

                
       
             

    }
    

}
