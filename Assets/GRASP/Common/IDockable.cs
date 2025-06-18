namespace Grasp.Common
{
    // Интерфейс для полиморфной стыковки различных объектов
    public interface IDockable
    {
        void Dock(DockingBay bay);
    }
}
