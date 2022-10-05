using System;
using System.Media;

namespace пианино
{
    internal class SystemSounds
    {
        static void Main()
        {
            Console.WriteLine("Переключение между октавами F2 и F4.");
            while (true)
            {
                ConsoleKeyInfo pey = Console.ReadKey();
                switch (pey.Key)
                {
                    case ConsoleKey.F2:
                        int[] O2 = new int[] { 524, 555, 587, 623, 660, 699, 740, 784, 831, 880, 933, 988 };
                        Octave("Вторая октава", O2);
                        break;
                    case ConsoleKey.F4:
                        int[] O4 = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3333, 3440, 3729, 3951 };
                        Octave("Четверая октава", O4);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Повторите всё заново");
                        }
                        break;
                }
            }
        }
        static void Octave(string octave, int[] oMass)
        {
            Console.Clear();
            Console.WriteLine(octave);
            Console.WriteLine("Чтобы выйти из этой октавы нажмите Enter, выберите октаву или выйдете из программы, нажав на Escape ");
            ConsoleKeyInfo key;
            int duration = 270;
            while (true)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.D)
                {
                    Sound(oMass[0], duration, "DO");

                }
                else if (key.Key == ConsoleKey.F)
                {
                    Sound(oMass[2], duration, "RE");

                }
                else if (key.Key == ConsoleKey.G)
                {
                    Sound(oMass[4], duration, "MI");

                }
                else if (key.Key == ConsoleKey.H)
                {
                    Sound(oMass[5], duration, "FA");

                }
                else if (key.Key == ConsoleKey.J)
                {
                    Sound(oMass[7], duration, "SOL");

                }
                else if (key.Key == ConsoleKey.K)
                {
                    Sound(oMass[9], duration, "LA");

                }
                else if (key.Key == ConsoleKey.L)
                {
                    Sound(oMass[11], duration, "SI");

                }
                else if (key.Key == ConsoleKey.R)
                {
                    Sound(oMass[1], duration, "DO#");

                }
                else if (key.Key == ConsoleKey.T)
                {
                    Sound(oMass[3], duration, "RE#");

                }
                else if (key.Key == ConsoleKey.Y)
                {
                    Sound(oMass[6], duration, "FA#");

                }
                else if (key.Key == ConsoleKey.U)
                {
                    Sound(oMass[8], duration, "SOL#");
                }
                else if (key.Key == ConsoleKey.I)
                {
                    Sound(oMass[10], duration, "LA#");
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Main();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.Write("Не та клавиша");
                    Console.WriteLine("_Используемые клавиши пианино_");
                    Console.WriteLine("_Чёрные клавиши  R T Y U I");
                    Console.WriteLine("_Белые клавиши D F G H J K L");
                }
            }
        }
        static void Sound(int frequency, int duration, string text = "")
        {
            Console.Clear();
            Console.Beep(frequency, duration);
            Console.WriteLine(text);


         }
     }    
}
    





