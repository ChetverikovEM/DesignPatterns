namespace AbstractFactory
{
    public class BattleShipFactory : IShipFactory
    {
        // Возвращаем двигатель, подходящий для боевого корабля
        public IEngine CreateEngine()
        {
            return new WarpEngine();
        }
    }
}
