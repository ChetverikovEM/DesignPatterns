namespace Visitor
{
    public interface IVisitor
    {
        // Операция над конкретной частью корабля
        void Visit(EnginePart part);
    }
}
