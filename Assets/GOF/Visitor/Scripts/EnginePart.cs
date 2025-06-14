using UnityEngine;

namespace Visitor
{
    public class EnginePart : MonoBehaviour, IShipElement
    {
        // Передаем себя посетителю
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
