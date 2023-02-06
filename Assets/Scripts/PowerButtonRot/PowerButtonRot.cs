using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButtonRot : GenericStep
{
    public GameObject powerButton;
    public bool rotCompleted = false;

    public AudioClip clip;
    public AudioSource audSource;

    public override void CustomStart()
    {
        powerButton.GetComponent<Grabbable>().enabled= true;
        audSource.clip = clip;
    }

    public override void CustomUpdate()
    {
        Quaternion currentRot = powerButton.transform.localRotation;
        
        if (currentRot.eulerAngles.y == 210f && rotCompleted == false)
        {
            rotCompleted = true;
            RotDone();
        }
        Debug.Log(currentRot.eulerAngles.y);
        
    }

    public void RotDone()
    {
        EventManager.stepCompleteInvoke();
        audSource.Play();
    }

    public override void CustomOnDisable()
    {
        powerButton.GetComponent<Grabbable>().enabled= false;
    }

}
