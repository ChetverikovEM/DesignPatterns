namespace FactoryMethod
{
    public class CargoStation : SpaceStation
    {
        // Создаем грузовой корабль
        protected override IShip CreateShip()
        {
            return new CargoShip();
        }
    }
}
