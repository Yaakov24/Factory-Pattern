namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number for your vehicle");
            int num = int.Parse(Console.ReadLine());
          var autoBlank = VehicleFactory.GetVehicle(num);
            autoBlank.Drive();
        }
    }
}
