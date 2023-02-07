using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractUI : GenericStep
{
    public GameObject cube;
    public Material greenMat;
    public Material blueMat;
    public Material redMat;
    public Material blackMat;

    bool onetime = true;
    bool secondtime = true;
    bool thirdtime = true;
    bool forthtime = true;
    public override void CustomStart()
    {
        cube.SetActive(true);
    }

    public void GreenColor()
    {
        cube.GetComponent<MeshRenderer>().material = greenMat;
        if (onetime)
        {
            EventManager.stepCompleteInvoke();
            onetime = false;
        }
    }

    public void BlueColor()
    {
        cube.GetComponent<MeshRenderer>().material = blueMat;
        if (secondtime)
        {
           
            EventManager.stepCompleteInvoke();
            secondtime = false;
        }
    }

    public void RedColor()
    {
        cube.GetComponent<MeshRenderer>().material = redMat;
        if (thirdtime)
        {
            EventManager.stepCompleteInvoke();
            thirdtime = false;
        }
    }

    public void BlackColor()
    {
        cube.GetComponent<MeshRenderer>().material = blackMat;
        if (forthtime)
        {
            EventManager.stepCompleteInvoke();
            forthtime = false;
        }
    }
}
