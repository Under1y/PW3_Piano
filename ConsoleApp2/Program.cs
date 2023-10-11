Console.WriteLine("Переключение между октавами F1, F2");

ConsoleKeyInfo cls;
ConsoleKeyInfo key;

int[] first_Octave = { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
int[] second_Octave = { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };

while (true)
{
    cls = Console.ReadKey();
    if (cls.Key == ConsoleKey.F2)
    {
        do
        {
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Q:
                    Console.Beep(first_Octave[0], 425);
                    break;
                case ConsoleKey.D2:
                    Console.Beep(first_Octave[1], 425);
                    break;
                case ConsoleKey.W:
                    Console.Beep(first_Octave[2], 425);
                    break;
                case ConsoleKey.D3:
                    Console.Beep(first_Octave[3], 425);
                    break;
                case ConsoleKey.E:
                    Console.Beep(first_Octave[4], 425);
                    break;
                case ConsoleKey.D4:
                    Console.Beep(first_Octave[5], 425);
                    break;
                case ConsoleKey.R:
                    Console.Beep(first_Octave[6], 425);
                    break;
                case ConsoleKey.D5:
                    Console.Beep(first_Octave[7], 425);
                    break;
                case ConsoleKey.T:
                    Console.Beep(first_Octave[8], 425);
                    break;
                case ConsoleKey.D6:
                    Console.Beep(first_Octave[9], 425);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(first_Octave[10], 425);
                    break;
                case ConsoleKey.D7:
                    Console.Beep(first_Octave[11], 425);
                    break;
            }
        }
        while (key.Key != ConsoleKey.Escape);
    }
    else if(cls.Key == ConsoleKey.F3)
    {
        do
        {
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Q:
                    Console.Beep(second_Octave[0], 425);
                    break;
                case ConsoleKey.D2:
                    Console.Beep(second_Octave[1], 425);
                    break;
                case ConsoleKey.W:
                    Console.Beep(second_Octave[2], 425);
                    break;
                case ConsoleKey.D3:
                    Console.Beep(second_Octave[3], 425);
                    break;
                case ConsoleKey.E:
                    Console.Beep(second_Octave[4], 425);
                    break;
                case ConsoleKey.D4:
                    Console.Beep(second_Octave[5], 425);
                    break;
                case ConsoleKey.R:
                    Console.Beep(second_Octave[6], 425);
                    break;
                case ConsoleKey.D5:
                    Console.Beep(second_Octave[7], 425);
                    break;
                case ConsoleKey.T:
                    Console.Beep(second_Octave[8], 425);
                    break;
                case ConsoleKey.D6:
                    Console.Beep(second_Octave[9], 425);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(second_Octave[10], 425);
                    break;
                case ConsoleKey.D7:
                    Console.Beep(second_Octave[11], 425);
                    break;
            }
        }
        while (key.Key != ConsoleKey.Escape);
    }
}