using UnityEngine;

namespace State
{
    public class FreeState : DockState
    {
        // Реакция на свободное место
        public override void Handle(DockingContext context)
        {
            Debug.Log("Место свободно");
            context.State = new OccupiedState();
        }
    }
}
