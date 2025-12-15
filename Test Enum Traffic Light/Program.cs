namespace Test_Enum_Traffic_Light
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight("Go");

            Console.WriteLine("Traffic Light Action: " + light.getAction());
            Console.WriteLine("Traffic Light Color: " + light.getColor());

            Console.ReadKey();
        }
    }
}
