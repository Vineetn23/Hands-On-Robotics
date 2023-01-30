using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasPos : MonoBehaviour
{
    public GameObject player;
    public GameObject canvas;
    void Start()
    {
        LeftSide();
    }

    public void LeftSide()
    {
        player.transform.position = new Vector3(1.331f, -3.9f, -1.455f);
        player.transform.rotation = Quaternion.Euler(0, 270, 0);
        canvas.transform.position = new Vector3(0.905f, -2.344f, -0.016f);
        canvas.transform.rotation = Quaternion.Euler(0, -27, 0);
    }

    public void RightSide()
    {
        player.transform.position = new Vector3(-1.151f, -3.9f, -1.52f);
        player.transform.rotation = Quaternion.Euler(0, 90, 0);
        canvas.transform.position = new Vector3(-0.845f, -2.344f, -0.358f);
        canvas.transform.rotation = Quaternion.Euler(0, 15.3f, 0);
    }

    public void FrontSide()
    {
        player.transform.position = new Vector3(-0.031f, -3.9f, 0.2f);
        player.transform.rotation = Quaternion.Euler(0, 180, 0);
        canvas.transform.position = new Vector3(1.183f, -2.344f, -0.437f);
        canvas.transform.rotation = Quaternion.Euler(0, 115.35f, 0);
    }

}
