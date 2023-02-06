using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSmartPad : GenericStep
{
    public GameObject smartPad;
    public override void CustomStart()
    {
        smartPad.GetComponent<BoxCollider>().enabled = true;
    }

    public void SmartPadPicked()
    {
        EventManager.stepCompleteInvoke();
    }
}
