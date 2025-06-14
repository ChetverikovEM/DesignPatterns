namespace FactoryMethod
{
    public class FighterStation : SpaceStation
    {
        // Создаем истребитель
        protected override IShip CreateShip()
        {
            return new FighterShip();
        }
    }
}
