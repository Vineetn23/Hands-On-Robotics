using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SmartPadInteractor : MonoBehaviour
{
    public UnityEvent smartPadGrabbed;
    public bool firstTime = true;

    public AudioClip clip;
    public AudioSource audSource;

    private void OnTriggerEnter(Collider other)
    {
        if (firstTime)
        {
            smartPadGrabbed?.Invoke();
            firstTime= false;
            audSource.clip = clip;
            audSource.Play();
        }
        
    }
}
