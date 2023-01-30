using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[CreateAssetMenu(fileName = "Step", menuName = "ScriptableObjects/Step")]
public class Step : ScriptableObject
{
    public string title;
    public string description;
    public Sprite refImage;
    public VideoClip videoClip;
}
