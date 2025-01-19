namespace KPO1
{

    class Engine
    {
        public int PedalSize { get; private set; }

        public Engine(int pedalSize)
        {
            PedalSize = pedalSize;
        }

        public override string ToString()
        {
            return $"Размер педалей = {PedalSize}";
        }
    }

}