using System;
using UnityEngine;

public class EventManager
{
    public static event Action stepCompleteEvent;

    public static void stepCompleteInvoke()
    {
        stepCompleteEvent?.Invoke();
    }

}
