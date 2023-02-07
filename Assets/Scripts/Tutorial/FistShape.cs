using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistShape : GenericStep
{
    public GameObject fistShape;
    bool firstTime = true;
    public override void CustomStart()
    {
        fistShape.SetActive(true);
    }

    public void FistShapeRecognized()
    {
        if (firstTime)
        {
            EventManager.stepCompleteInvoke();
            firstTime = false;
        }
    }
}
