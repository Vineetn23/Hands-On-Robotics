using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SmartPadSwitchOn : GenericStep
{
    public GameObject smartPadSwitch;
    public bool firstTime = true;
    public TextMeshProUGUI displayText;

    public AudioClip clip;
    public AudioSource audSource;
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
            displayText.text = string.Empty;
            displayText.text = "SmartPad Switched On";
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
        smartPadSwitch.GetComponent<PokeInteractable>().enabled = false;
        smartPadSwitch.GetComponent<InteractableUnityEventWrapper>().enabled = false;
    }
}
