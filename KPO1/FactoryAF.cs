namespace KPO1
{
    class FactoryAF
    {
        private List<Car> cars = new List<Car>();
        private List<Customer> customers = new List<Customer>();

        public void AddCar(int pedalSize, int numb)
        {
            cars.Add(new Car(pedalSize, numb));
        }

        public void AddCustomer(string name)
        {
            customers.Add(new Customer(name));
        }

        public void SaleCar()
        {
            foreach (var customer in customers)
            {
                if (cars.Count > 0)
                {
                    customer.Car = cars[0];
                    cars.RemoveAt(0);
                }
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Больше нет машин.");
            }
            else
            {
                Console.WriteLine("Оставшиеся машины:");
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }

        public void CurrentStatus()
        {
            Console.WriteLine("Машины:");
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("Покупатели:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
    }
}
