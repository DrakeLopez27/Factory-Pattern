namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            int NumberOfWheels;
            bool userInput = false;

            do
            {
                Console.WriteLine("Enter the amount of wheels on the vehicle you want created:");

                userInput = int.TryParse(Console.ReadLine(), out NumberOfWheels);

            } while (!userInput);

           var vehicle = VehicleFactory.GetVehicle(NumberOfWheels);
            vehicle.Drive();
        }
    }
}
