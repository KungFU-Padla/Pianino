namespace Piano2
{
    internal class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Чёрные клавиши: Q, W, E, R, T" + "\n" +
                              "Белые клавиши: A, S, D, F, G, H, J" + "\n" +
                              "Октавы: F1, F2, F3, F4" + "\n" +
                              "Для выхода программы нажмите клавишу Escape" + "\n" + "\n" +
                              "Выберите октаву");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.F1:
                    FirtsOctave();
                    break;
                case ConsoleKey.F2:
                    SecondOctave();
                    break;
                case ConsoleKey.F3:
                    ThirdOctave();
                    break;
                case ConsoleKey.F4:
                    ForthOctave();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;

            }
        }

        static void FirtsOctave()
        {
            int[] Octave = new int[]
                { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            Note(Octave);
        }

        static void SecondOctave()
        {
            int[] Octave = new int[]
                { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            Note(Octave);

        }

        static void ThirdOctave()
        {
            int[] Octave = new int[]
                { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            Note(Octave);
        }

        static void ForthOctave()
        {
            int[] Octave = new int[]
                { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            Note(Octave);
        }

        static void Note(int[] Octave)
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.Z:
                        MakeSound(Octave[0]);
                        break;
                    case ConsoleKey.S:
                        MakeSound(Octave[1]);
                        break;
                    case ConsoleKey.X:
                        MakeSound(Octave[2]);
                        break;
                    case ConsoleKey.D:
                        MakeSound(Octave[3]);
                        break;
                    case ConsoleKey.C:
                        MakeSound(Octave[4]);
                        break;
                    case ConsoleKey.V:
                        MakeSound(Octave[5]);
                        break;
                    case ConsoleKey.G:
                        MakeSound(Octave[6]);
                        break;
                    case ConsoleKey.B:
                        MakeSound(Octave[7]);
                        break;
                    case ConsoleKey.H:
                        MakeSound(Octave[8]);
                        break;
                    case ConsoleKey.N:
                        MakeSound(Octave[9]);
                        break;
                    case ConsoleKey.J:
                        MakeSound(Octave[10]);
                        break;
                    case ConsoleKey.M:
                        MakeSound(Octave[11]);
                        break;
                    case ConsoleKey.Spacebar:
                        Main();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void MakeSound(int frequency)
        {
            Console.Beep(frequency, 500);
            Console.Clear();
        }
    }
}
    
