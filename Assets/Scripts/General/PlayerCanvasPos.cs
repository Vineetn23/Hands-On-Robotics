using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasPos : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        LeftSide();
    }

    public void LeftSide()
    {
        player.transform.position = new Vector3(1.20099998f, 0.129999995f, -2.69499993f);
        player.transform.rotation = Quaternion.Euler(0, -90, 0);
    }

    public void RightSide()
    {
        player.transform.position = new Vector3(-1.20000005f, 0.129999995f, -2.64299989f);
        player.transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    public void BackSide()
    {
        player.transform.position = new Vector3(0.00899999961f, 0.129999995f, -3.88599992f);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void FrontSide()
    {
        player.transform.position = new Vector3(-0.0500000007f, 0.129999995f, -1.079f);
        player.transform.rotation = Quaternion.Euler(0, 180, 0);
    }

}
