using Facebook.WitAi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericStep : MonoBehaviour
{
    [SerializeField] public int totalSubSteps;
    [SerializeField] public Step content;
    public abstract void CustomStart();

    public virtual void CustomUpdate()
    {
        return;
    }

    public virtual void CustomOnDisable()
    {
        return;
    }
}
