namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eh what you like");
            Console.WriteLine("Musubi or one Drink");
            string menuItem = Console.ReadLine();

            MusubiFactory factory = new MusubiFactory();
            IMusubiTruck foodOrder = factory.GetFood(menuItem);

            foodOrder.FoodItem();

            
        }
    }
}
