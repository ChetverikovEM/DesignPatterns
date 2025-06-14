namespace AbstractFactory
{
    public class CargoShipFactory : IShipFactory
    {
        // Возвращаем двигатель, подходящий для грузового корабля
        public IEngine CreateEngine()
        {
            return new IonEngine();
        }
    }
}
