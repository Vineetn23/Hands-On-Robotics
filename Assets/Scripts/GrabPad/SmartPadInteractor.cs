using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SmartPadInteractor : MonoBehaviour
{
    public UnityEvent smartPadGrabbed;
    bool firstTime = true;
    private void OnTriggerEnter(Collider other)
    {
        if (firstTime)
        {
            smartPadGrabbed?.Invoke();
            firstTime= false;
        }
        
    }
}
