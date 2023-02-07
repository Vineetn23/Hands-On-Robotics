using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : GenericStep
{
    public override void CustomStart()
    {

    }

    public void CloseDoors()
    {
        EventManager.stepCompleteInvoke();
    }

}
 