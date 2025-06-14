using UnityEngine;

namespace State
{
    public class OccupiedState : DockState
    {
        // Реакция на занятое место
        public override void Handle(DockingContext context)
        {
            Debug.Log("Место занято");
            context.State = new FreeState();
        }
    }
}
