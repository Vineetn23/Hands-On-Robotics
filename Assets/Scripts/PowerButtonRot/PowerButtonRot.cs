using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButtonRot : GenericStep
{
    public GameObject powerButton;
     public bool rotCompleted = false;
    public override void CustomStart()
    {
        powerButton.GetComponent<Grabbable>().enabled= true;
    }

    public override void CustomUpdate()
    {
        Debug.Log(powerButton.transform.localRotation.z * 360);
        if((powerButton.transform.localRotation.z * 360 > 140f) && rotCompleted == false)
        {
            rotCompleted= true;
            RotDone();
        }
    }

    public void RotDone()
    {
        EventManager.stepCompleteInvoke();
    }

    public override void CustomOnDisable()
    {
        powerButton.GetComponent<Grabbable>().enabled= false;
    }

}
