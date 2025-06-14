namespace AbstractFactory
{
    public interface IShipFactory
    {
        // Создание конкретного двигателя
        IEngine CreateEngine();
    }
}
