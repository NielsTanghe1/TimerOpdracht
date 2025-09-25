namespace TimerOpdracht
{
    internal class Program
    {
        public delegate void alarmType();

        static void Main(string[] args)
        {
            Tuple<int, int, bool> alarm = Tuple.Create(10, 5, true);
            int length = 0;
            int snooze = 0;
            alarmType at1 = new alarmType(geluid); // IDE0090: simplified 'new' expression
            alarmType at2 = new alarmType(licht);
            alarmType at3 = new alarmType(boodschap);
            int choice = 0;

            do //Menu lus
            {
                Console.WriteLine("1. Stel de tijd in van je wekker");
                Console.WriteLine("2. Stel de sluimertijd in");
                Console.WriteLine("3. Stop de wekker");
                Console.WriteLine("4. Sluimer de wekker");
                Console.WriteLine("5. Start de wekker");
                Console.WriteLine("6. Geluid");
                Console.WriteLine("7. Licht");
                Console.WriteLine("8. Boodschap");
                Console.WriteLine("Press 0 to quit...");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ongeldige invoer, probeer het opnieuw.");

                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Stel de tijd in van je wekker(seconden)");
                        length = Console.Read();
                        alarm = Tuple.Create(length, 5, true);
                        break;
                    case 2:
                        Console.WriteLine("Stel de sluimertijd in(seconden)");
                        snooze = Console.Read();
                        alarm = Tuple.Create(length, snooze, true);
                        break;
                    case 3:
                        Console.WriteLine("Stop de wekker");
                        break;
                    case 4:
                        Console.WriteLine("Sluimer de wekker");
                        break;
                    case 5:
                        Console.WriteLine("Start de wekker");
                        break;
                    case 6:
                        at1();
                        break;
                    case 7:
                        at2();
                        break;
                    case 8:
                        at3();
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
        public static void geluid()
        {
            Console.WriteLine("Alarm is ringing!");
        }
        public static void licht()
        {
            Console.WriteLine("Alarm is flashing!");
        }
        public static void boodschap()
        {
            Console.WriteLine("Alarm is messaging!");
        }
    }
}
