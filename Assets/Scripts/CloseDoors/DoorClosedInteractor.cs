using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorClosedInteractor : MonoBehaviour
{
    public UnityEvent snapComplete;
    public PlayerCanvasPos playerCanvasPos;
    public AudioSource audioSource;
    public AudioClip doorClip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FrontGlass")
        {
            other.gameObject.GetComponent<SphereCollider>().enabled = false;
            other.gameObject.GetComponent<Grabbable>().enabled = false;
            audioSource.clip = doorClip;
            audioSource.Play();
            snapComplete?.Invoke();
        }
        if (other.gameObject.name == "LeftGlass")
        {
            other.gameObject.GetComponent<SphereCollider>().enabled = false;
            other.gameObject.GetComponent<Grabbable>().enabled = false;
            audioSource.clip = doorClip;
            audioSource.Play();
            snapComplete?.Invoke();
            playerCanvasPos.BackSide();
        }
        if (other.gameObject.name == "RightGlass")
        {
            other.gameObject.GetComponent<SphereCollider>().enabled = false;
            other.gameObject.GetComponent<Grabbable>().enabled = false;
            audioSource.clip = doorClip;
            audioSource.Play();
            snapComplete?.Invoke();
            playerCanvasPos.FrontSide();
        }

        if (other.gameObject.name == "BackGlass")
        {
           
            other.gameObject.GetComponent<SphereCollider>().enabled = false;
            other.gameObject.GetComponent<Grabbable>().enabled = false;
            audioSource.clip = doorClip;
            audioSource.Play();
            snapComplete?.Invoke();
            playerCanvasPos.RightSide();
        }
    }



}
