using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : GenericStep
{
    public GameObject canvas;
    public override void CustomStart()
    {
        canvas.SetActive(true);
    }

    public void SceneChangeToRoboticArm()
    {
        SceneManager.LoadScene("RoboticArm");
    }
}
