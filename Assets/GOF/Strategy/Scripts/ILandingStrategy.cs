namespace Strategy
{
    public interface ILandingStrategy
    {
        // Выполнить посадку по выбранной стратегии
        void Land(string shipName);
    }
}
