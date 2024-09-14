namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of vehicle would you like to make?");
            string response = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.GetVehicle(response);
            vehicle.Build();
            Console.ReadLine();

        }
    }
}
