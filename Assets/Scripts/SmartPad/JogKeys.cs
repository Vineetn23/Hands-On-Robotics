using Oculus.Interaction;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogKeys : GenericStep
{
    public float rotationSpeed = 10f;

    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;

    bool a1Neg = false;
    bool a2Neg = false;
    bool a3Neg = false;
    bool a4Neg = false;
    bool a5Neg = false;
    bool a6Neg = false;
    bool a1Pos = false;
    bool a2Pos = false;
    bool a3Pos = false;
    bool a4Pos = false;
    bool a5Pos = false;
    bool a6Pos = false;

    public GameObject A1PosButton;
    public GameObject A2PosButton;
    public GameObject A3PosButton;
    public GameObject A4PosButton;
    public GameObject A5PosButton;
    public GameObject A6PosButton;
    public GameObject A1NegButton;
    public GameObject A2NegButton;
    public GameObject A3NegButton;
    public GameObject A4NegButton;
    public GameObject A5NegButton;
    public GameObject A6NegButton;

    public AudioSource audioSource;
    public AudioClip robotClip;

    public override void CustomStart()
    {
        A1PosButton.GetComponent<PokeInteractable>().enabled = true;
        A2PosButton.GetComponent<PokeInteractable>().enabled = true;
        A3PosButton.GetComponent<PokeInteractable>().enabled = true;
        A4PosButton.GetComponent<PokeInteractable>().enabled = true;
        A5PosButton.GetComponent<PokeInteractable>().enabled = true;
        A6PosButton.GetComponent<PokeInteractable>().enabled = true;
        A1NegButton.GetComponent<PokeInteractable>().enabled = true;
        A2NegButton.GetComponent<PokeInteractable>().enabled = true;
        A3NegButton.GetComponent<PokeInteractable>().enabled = true;
        A4NegButton.GetComponent<PokeInteractable>().enabled = true;
        A5NegButton.GetComponent<PokeInteractable>().enabled = true;
        A6NegButton.GetComponent<PokeInteractable>().enabled = true;
    }

    public override void CustomUpdate()
    {

    }

    private void Update()
    {
        if (a1Pos)
        {
            A1.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A1.transform.localEulerAngles;
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -170, 170);
            A1.transform.localEulerAngles = eulerAngles;
        }
        if (a2Pos)
        {
            A2.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A2.transform.localEulerAngles;
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -70, 14);
            A2.transform.localEulerAngles = eulerAngles;
        }
        if (a3Pos)
        {
            A3.transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A3.transform.localEulerAngles;
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -45, 75);
            A3.transform.localEulerAngles = eulerAngles;
        }
        if (a4Pos)
        {
            A4.transform.Rotate(-Vector3.left * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A4.transform.localEulerAngles;
            eulerAngles.x = Mathf.Clamp((eulerAngles.x <= 180) ? eulerAngles.x : -(360 - eulerAngles.x), -180, 0);
            A4.transform.localEulerAngles = eulerAngles;
        }
        if (a5Pos)
        {
            A5.transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A5.transform.localEulerAngles;
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -90, 90);
            A5.transform.localEulerAngles = eulerAngles;
        }
        if (a6Pos)
        {
            A6.transform.Rotate(-Vector3.left * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A6.transform.localEulerAngles;
            eulerAngles.x = Mathf.Clamp((eulerAngles.x <= 180) ? eulerAngles.x : -(360 - eulerAngles.x), -180, 0);
            A6.transform.localEulerAngles = eulerAngles;
        }
        if (a1Neg)
        {
            A1.transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A1.transform.localEulerAngles;
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -170, 170);
            A1.transform.localEulerAngles = eulerAngles;
        }
        if (a2Neg)
        {
            A2.transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A2.transform.localEulerAngles;
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -70, 14);
            A2.transform.localEulerAngles = eulerAngles;
        }
        if (a3Neg)
        {
            A3.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A3.transform.localEulerAngles;
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -45, 75);
            A3.transform.localEulerAngles = eulerAngles;
        }
        if (a4Neg)
        {
            A4.transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A4.transform.localEulerAngles;
            eulerAngles.x = Mathf.Clamp((eulerAngles.x <= 180) ? eulerAngles.x : -(360 - eulerAngles.x), -180, 0);
            A4.transform.localEulerAngles = eulerAngles;
        }
        if (a5Neg)
        {
            A5.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A5.transform.localEulerAngles;
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -90, 90);
            A5.transform.localEulerAngles = eulerAngles;
        }
        if (a6Neg)
        {
            A6.transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A6.transform.localEulerAngles;
            eulerAngles.x = Mathf.Clamp((eulerAngles.x <= 180) ? eulerAngles.x : -(360 - eulerAngles.x), -180, 0);
            A6.transform.localEulerAngles = eulerAngles;
        }
    }


    public void A1Negative()
    {
        a1Neg = true;

    }

    public void A1Positive()
    {
        a1Pos = true;

    }

    public void A2Negative()
    {
        a2Neg = true;

    }

    public void A2Positive()
    {
        a2Pos = true;

    }

    public void A3Negative()
    {
        a3Neg = true;

    }

    public void A3Positive()
    {
        a3Pos = true;

    }

    public void A4Negative()
    {
        a4Neg = true;

    }

    public void A4Positive()
    {
        a4Pos = true;

    }

    public void A5Negative()
    {
        a5Neg = true;

    }

    public void A5Positive()
    {
        a5Pos = true;

    }

    public void A6Negative()
    {
        a6Neg = true;

    }

    public void A6Positive()
    {
        a6Pos = true;

    }

    public void SoundPlayRobot()
    {
        audioSource.clip = robotClip;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void Nothing()
    {
        a1Neg = false;
        a2Neg = false;
        a3Neg = false;
        a4Neg = false;
        a5Neg = false;
        a6Neg = false;
        a1Pos = false;
        a2Pos = false;
        a3Pos = false;
        a4Pos = false;
        a5Pos = false;
        a6Pos = false;
        audioSource.Stop();
    }
}
