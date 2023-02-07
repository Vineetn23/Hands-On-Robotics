using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConnectionManagerSwitch : GenericStep
{
    public GameObject connectionSwitch;
    bool rotCompleted = false;
    public TextMeshProUGUI displayText;

    public AudioClip clip;
    public AudioSource audSource;
    public override void CustomStart()
    {
        connectionSwitch.GetComponent<Grabbable>().enabled= true;
        audSource.clip= clip;
    }

    public override void CustomUpdate()
    {
        Quaternion currentRot = connectionSwitch.transform.localRotation;

        if (rotCompleted == false && currentRot.eulerAngles.z == 90)
        {
            rotCompleted = true;
            RotDone();
        }
        
    }


    public void RotDone()
    {
        EventManager.stepCompleteInvoke();
        displayText.text = string.Empty;
        displayText.text = "Manual Mode Started";
        audSource.clip = clip;
        audSource.Play();
    }

    public override void CustomOnDisable()
    {
        connectionSwitch.GetComponent<Grabbable>().enabled = false;
    }
}
