using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerButtonPush : GenericStep
{
    public GameObject powerButton;
    public bool firstTime = true;

    public AudioClip clip;
    public AudioSource audSource;

    public override void CustomStart()
    {
        powerButton.GetComponent<PokeInteractable>().enabled= true;
        powerButton.GetComponent<InteractableUnityEventWrapper>().enabled= true;
    }

    public void PowerButtonPushed()
    {
        if (firstTime)
        {
            EventManager.stepCompleteInvoke();
            firstTime = false;
        }
        audSource.clip = clip;
        audSource.Play();
    }

    public override void CustomOnDisable()
    {
        StartCoroutine(Delay());
        
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        powerButton.GetComponent<PokeInteractable>().enabled = false;
        powerButton.GetComponent<InteractableUnityEventWrapper>().enabled = false;
    }

}
