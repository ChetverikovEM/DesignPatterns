namespace State
{
    public abstract class DockState
    {
        // Выполнить действия при текущем состоянии
        public abstract void Handle(DockingContext context);
    }
}
