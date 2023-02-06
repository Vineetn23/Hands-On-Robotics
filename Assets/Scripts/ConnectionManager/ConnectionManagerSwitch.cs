using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionManagerSwitch : GenericStep
{
    public GameObject connectionSwitch;
    bool rotCompleted = false;
    public override void CustomStart()
    {
        connectionSwitch.GetComponent<Grabbable>().enabled= true;
    }

    public override void CustomUpdate()
    {
        Quaternion currentRot = connectionSwitch.transform.localRotation;

        if(rotCompleted == false && currentRot.eulerAngles.z == 90)
        {
            rotCompleted = true;
            RotDone();
        }
        
    }


    public void RotDone()
    {
        EventManager.stepCompleteInvoke();
    }

    public override void CustomOnDisable()
    {
        connectionSwitch.GetComponent<Grabbable>().enabled = false;
    }
}
