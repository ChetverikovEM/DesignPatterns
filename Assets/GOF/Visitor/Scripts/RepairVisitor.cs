using UnityEngine;

namespace Visitor
{
    public class RepairVisitor : IVisitor
    {
        // Действие посетителя при посещении части
        public void Visit(EnginePart part)
        {
            Debug.Log("Ремонт двигателя");
        }
    }
}
