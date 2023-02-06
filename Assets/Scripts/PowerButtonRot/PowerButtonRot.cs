using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButtonRot : GenericStep
{
    public GameObject powerButton;
    bool rotCompleted = false;
    public override void CustomStart()
    {
        powerButton.GetComponent<Grabbable>().enabled= true;
    }

    public override void CustomUpdate()
    {
        Quaternion currentRot = powerButton.transform.localRotation;
        if (currentRot.eulerAngles.z == 150f && rotCompleted == false)
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
