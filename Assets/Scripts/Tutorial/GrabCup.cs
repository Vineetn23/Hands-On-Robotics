using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabCup : GenericStep
{
    bool firstTime = true;
    public GameObject handCanvas;
    public override void CustomStart()
    {
        handCanvas.SetActive(false);
    }

    public void CupGrabbed()
    {
        if (firstTime)
        {
            EventManager.stepCompleteInvoke();
            firstTime = false;
        }
    }
}
