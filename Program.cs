using System.Timers;

namespace TimerOpdracht
{
    internal class Program
    {
        public delegate void alarmType();

        static void Main(string[] args)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            int sluimertijd = 0;
            int length = 0;
            int snooze = 0;
            int choice = 0;

            do //Menu lus
            {
                Console.WriteLine("1. Stel de tijd in van je wekker");
                Console.WriteLine("2. Stel de sluimertijd in");
                Console.WriteLine("3. Stop de wekker");
                Console.WriteLine("4. Sluimer de wekker");
                Console.WriteLine("5. Start de wekker");
                Console.WriteLine("6. Voeg geluid toe");
                Console.WriteLine("7. Voeg licht toe");
                Console.WriteLine("8. Voeg boodschap toe");
                Console.WriteLine("0. Sluit af");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ongeldige invoer, probeer het opnieuw.");

                }
                ClearConsole();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Stel de tijd in van je wekker(seconden)");
                        length = Convert.ToInt32(Console.ReadLine());
                        aTimer.Interval = length * 1000; // Convert seconds to milliseconds
                        break;
                    case 2:
                        Console.WriteLine("Stel de sluimertijd in(seconden)");
                        snooze = Convert.ToInt32(Console.ReadLine());
                        sluimertijd = snooze * 1000; // Convert seconds to milliseconds
                        break;
                    case 3:
                        Console.WriteLine("Wekker gestopt");
                        aTimer.Stop();
                        break;
                    case 4:
                        Console.WriteLine("Wekker is gesluimerd voor " + sluimertijd / 1000 + " seconden");
                        aTimer.Interval += sluimertijd;
                        break;
                    case 5:
                        Console.WriteLine("Start de wekker");
                        aTimer.Enabled = true;
                        break;
                    case 6:
                        Console.WriteLine("Geluid ingesteld");
                        aTimer.Elapsed += geluid;
                        break;
                    case 7:
                        Console.WriteLine("Licht ingesteld");
                        aTimer.Elapsed += licht;
                        break;
                    case 8:
                        Console.WriteLine("Boodschap ingesteld");
                        aTimer.Elapsed += boodschap;
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze, probeer het opnieuw.");
                        break;
                }
            } while (choice != 0);


        }
        public static void geluid(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Alarm is ringing!");
        }
        public static void licht(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Alarm is flashing!");
        }
        public static void boodschap(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Alarm is messaging!");
        }
        public static void ClearConsole()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
        }

    }
}
