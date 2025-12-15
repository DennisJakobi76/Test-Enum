namespace Test_Enum_Traffic_Light
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Traffic Light System ===");
                Console.WriteLine("Wählen Sie eine Aktion:");
                Console.WriteLine("1 - Stop");
                Console.WriteLine("2 - Wait");
                Console.WriteLine("3 - Go");
                Console.WriteLine("0 - Programm beenden");
                Console.Write("\nIhre Auswahl: ");

                string input = Console.ReadLine();
                string action = "";

                switch (input)
                {
                    case "1":
                        action = "Stop";
                        break;
                    case "2":
                        action = "Wait";
                        break;
                    case "3":
                        action = "Go";
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Programm wird beendet...");
                        continue;
                    default:
                        Console.WriteLine("Ungültige Eingabe! Bitte wählen Sie 0-3.");
                        continue;
                }

                TrafficLight light = new TrafficLight(action);

                Console.WriteLine("\nErgebnis:");
                Console.WriteLine("Traffic Light Action: " + light.getAction());
                Console.WriteLine("Traffic Light Color: " + light.getColor());
            }

            Console.WriteLine("\nDrücken Sie eine beliebige Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}
