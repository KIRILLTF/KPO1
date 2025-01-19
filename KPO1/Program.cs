namespace KPO1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryAF factory = new FactoryAF();

            factory.AddCar(30, 199);
            factory.AddCar(35, 200);
            factory.AddCar(40, 201);

            factory.AddCustomer("Миша");
            factory.AddCustomer("Кирилл");
            factory.AddCustomer("Леха");

            Console.WriteLine("Перед покупкой:");
            factory.CurrentStatus();

            factory.SaleCar();

            Console.WriteLine("\nПосле покупки:");
            factory.CurrentStatus();
        }
    }
}