using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartPadSwitchOn : GenericStep
{
    public GameObject smartPadSwitch;
    public bool firstTime = true;
    public override void CustomStart()
    {
        smartPadSwitch.GetComponent<PokeInteractable>().enabled= true;
        smartPadSwitch.GetComponent<InteractableUnityEventWrapper>().enabled= true;
    }

    public void ButtonPushed()
    {
        if (firstTime)
        {
            EventManager.stepCompleteInvoke();
            firstTime= false;
        }
    }

    public override void CustomOnDisable()
    {
        StartCoroutine(Delay());

    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        smartPadSwitch.GetComponent<PokeInteractable>().enabled = false;
        smartPadSwitch.GetComponent<InteractableUnityEventWrapper>().enabled = false;
    }
}
