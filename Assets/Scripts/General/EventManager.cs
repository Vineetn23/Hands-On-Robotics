using System;

public class EventManager
{
    public static event Action stepCompleteEvent;

    public static void stepCompleteInvoke()
    {
        stepCompleteEvent?.Invoke();
    }

}
