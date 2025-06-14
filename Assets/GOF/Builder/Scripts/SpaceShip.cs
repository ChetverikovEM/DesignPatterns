namespace Builder
{
    public class SpaceShip
    {
        // Название корабля
        public string Name { get; }
        // Наличие вооружения
        public bool HasWeapons { get; }
        // Наличие щитов
        public bool HasShields { get; }

        // Конструктор заполняет параметры корабля
        public SpaceShip(string name, bool weapons, bool shields)
        {
            Name = name;
            HasWeapons = weapons;
            HasShields = shields;
        }
    }
}
