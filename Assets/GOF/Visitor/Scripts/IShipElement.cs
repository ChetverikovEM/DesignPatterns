namespace Visitor
{
    public interface IShipElement
    {
        // Принять посетителя
        void Accept(IVisitor visitor);
    }
}
