using Oculus.Interaction;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JogKeys : GenericStep
{
    public float rotationSpeed = 5f;

    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A51;
    public GameObject A52;

    bool a1Neg = false;
    bool a2Neg = false;
    bool a3Neg = false;
    bool a4Neg = false;
    bool a5Neg = false;
    bool a1Pos = false;
    bool a2Pos = false;
    bool a3Pos = false;
    bool a4Pos = false;
    bool a5Pos = false;

    public GameObject A1PosButton;
    public GameObject A2PosButton;
    public GameObject A3PosButton;
    public GameObject A4PosButton;
    public GameObject A5PosButton;
    public GameObject A1NegButton;
    public GameObject A2NegButton;
    public GameObject A3NegButton;
    public GameObject A4NegButton;
    public GameObject A5NegButton;

    public GameObject speed1;
    public GameObject speed2;
    public GameObject speed3;
    public GameObject speed4;
    public GameObject speed5;

    public GameObject lockButton;



    public AudioSource audioSource;
    public AudioClip robotClip;

    bool lockButtonBool = false;

    public TextMeshProUGUI displayText;

    public override void CustomStart()
    {
        A1PosButton.GetComponent<PokeInteractable>().enabled = true;
        A2PosButton.GetComponent<PokeInteractable>().enabled = true;
        A3PosButton.GetComponent<PokeInteractable>().enabled = true;
        A4PosButton.GetComponent<PokeInteractable>().enabled = true;
        A5PosButton.GetComponent<PokeInteractable>().enabled = true;
        A1NegButton.GetComponent<PokeInteractable>().enabled = true;
        A2NegButton.GetComponent<PokeInteractable>().enabled = true;
        A3NegButton.GetComponent<PokeInteractable>().enabled = true;
        A4NegButton.GetComponent<PokeInteractable>().enabled = true;
        A5NegButton.GetComponent<PokeInteractable>().enabled = true;
        speed1.GetComponent<PokeInteractable>().enabled = true;
        speed2.GetComponent<PokeInteractable>().enabled = true;
        speed3.GetComponent<PokeInteractable>().enabled = true;
        speed4.GetComponent<PokeInteractable>().enabled = true;
        speed5.GetComponent<PokeInteractable>().enabled = true;
        lockButton.GetComponent<PokeInteractable>().enabled = true;
        audioSource.clip = robotClip;
        audioSource.loop = true;
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
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -60, 60);
            A1.transform.localEulerAngles = eulerAngles;
        }
        if (a2Pos)
        {
            A2.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A2.transform.localEulerAngles;
            eulerAngles.z = Mathf.Clamp((eulerAngles.z <= 180) ? eulerAngles.z : -(360 - eulerAngles.z), -10, 20);
            A2.transform.localEulerAngles = eulerAngles;
        }
        if (a3Pos)
        {
            A3.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A3.transform.localEulerAngles;
            eulerAngles.z = Mathf.Clamp((eulerAngles.z <= 180) ? eulerAngles.z : -(360 - eulerAngles.z), 0, 75);
            A3.transform.localEulerAngles = eulerAngles;
        }
        if (a4Pos)
        {
            A4.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A4.transform.localEulerAngles;
            eulerAngles.z = Mathf.Clamp((eulerAngles.z <= 180) ? eulerAngles.z : -(360 - eulerAngles.z), 0, 90);
            A4.transform.localEulerAngles = eulerAngles;
        }
        if (a5Pos)
        {
            A51.transform.Rotate(-Vector3.left * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A51.transform.localEulerAngles;
            eulerAngles.x = Mathf.Clamp((eulerAngles.x <= 180) ? eulerAngles.x : -(360 - eulerAngles.x), -50, -10);
            A51.transform.localEulerAngles = eulerAngles;

            A52.transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles2 = A52.transform.localEulerAngles;
            eulerAngles2.x = Mathf.Clamp((eulerAngles2.x <= 180) ? eulerAngles2.x : -(360 - eulerAngles2.x), 10, 50);
            A52.transform.localEulerAngles = eulerAngles2;
        }

        if (a1Neg)
        {
            A1.transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A1.transform.localEulerAngles;
            eulerAngles.y = Mathf.Clamp((eulerAngles.y <= 180) ? eulerAngles.y : -(360 - eulerAngles.y), -60, 60);
            A1.transform.localEulerAngles = eulerAngles;
        }
        if (a2Neg)
        {
            A2.transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A2.transform.localEulerAngles;
            eulerAngles.z = Mathf.Clamp((eulerAngles.z <= 180) ? eulerAngles.z : -(360 - eulerAngles.z), -10, 20);
            A2.transform.localEulerAngles = eulerAngles;
        }
        if (a3Neg)
        {
            A3.transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A3.transform.localEulerAngles;
            eulerAngles.z = Mathf.Clamp((eulerAngles.z <= 180) ? eulerAngles.z : -(360 - eulerAngles.z), 0, 75);
            A3.transform.localEulerAngles = eulerAngles;
        }
        if (a4Neg)
        {
            A4.transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A4.transform.localEulerAngles;
            eulerAngles.z = Mathf.Clamp((eulerAngles.z <= 180) ? eulerAngles.z : -(360 - eulerAngles.z), 0, 90);
            A4.transform.localEulerAngles = eulerAngles;
        }
        if (a5Neg)
        {
            A51.transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles = A51.transform.localEulerAngles;
            eulerAngles.x = Mathf.Clamp((eulerAngles.x <= 180) ? eulerAngles.x : -(360 - eulerAngles.x), -50, -10);
            A51.transform.localEulerAngles = eulerAngles;

            A52.transform.Rotate(-Vector3.left * rotationSpeed * Time.deltaTime, Space.Self);
            Vector3 eulerAngles2 = A52.transform.localEulerAngles;
            eulerAngles2.x = Mathf.Clamp((eulerAngles2.x <= 180) ? eulerAngles2.x : -(360 - eulerAngles2.x), 10, 50);
            A52.transform.localEulerAngles = eulerAngles2;
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

    public void SoundPlayRobot()
    {
        
        audioSource.Play();
    }

    public void Nothing()
    {
        a1Neg = false;
        a2Neg = false;
        a3Neg = false;
        a4Neg = false;
        a5Neg = false;
        a1Pos = false;
        a2Pos = false;
        a3Pos = false;
        a4Pos = false;
        a5Pos = false;
        audioSource.Stop();
    }

    public void LockButton()
    {
        if (!lockButtonBool)
        {
            A5NegButton.GetComponent<PokeInteractable>().enabled = false;
            A5PosButton.GetComponent<PokeInteractable>().enabled = false;
            lockButtonBool = true;
            displayText.text = string.Empty;
            displayText.text = "Part 5 is Locked";
        }
        else
        {
            A5NegButton.GetComponent<PokeInteractable>().enabled = true;
            A5PosButton.GetComponent<PokeInteractable>().enabled = true;
            lockButtonBool = false;
            displayText.text = string.Empty;
            displayText.text = "Part 5 is Unlocked";
        }
    }

    public void speed1x()
    {
        rotationSpeed = 5f;
        displayText.text = string.Empty;
        displayText.text = "Rotation Speed is 1x";
    }

    public void speed2x()
    {
        rotationSpeed = 10f;
        displayText.text = string.Empty;
        displayText.text = "Rotation Speed is 2x";
    }

    public void speed3x()
    {
        rotationSpeed = 15f;
        displayText.text = string.Empty;
        displayText.text = "Rotation Speed is 3x";
    }

    public void speed4x()
    {
        rotationSpeed = 20f;
        displayText.text = string.Empty;
        displayText.text = "Rotation Speed is 4x";
    }

    public void speed5x()
    {
        rotationSpeed = 25f;
        displayText.text = string.Empty;
        displayText.text = "Rotation Speed is 5x";
    }
}
