namespace KPO1
{
    class Customer
    {
        public string Name { get; private set; }
        public Car Car { get; set; }

        public Customer(string name) 
        { 
            Name = name;
        }

        public override string ToString()
        {
            return $"Имя: {Name}";
        }
    }
}
