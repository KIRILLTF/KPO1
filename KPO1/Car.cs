namespace KPO1
{
    class Car
    {
        private static int carCounter = 0;

        public int SerialNumber { get; private set; }
        public Engine Engine { get; private set; }

        public Car(int pedalSize, int numb)
        {
            carCounter++;
            Engine = new Engine(pedalSize);
            SerialNumber = numb;
        }

        public override string ToString()
        {
            return $"Номер = {SerialNumber}";
        }
    }
}