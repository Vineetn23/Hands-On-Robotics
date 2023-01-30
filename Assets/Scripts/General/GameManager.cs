using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] GenericStep[] steps;
    int totalSubSteps;
    [SerializeField]int currentStepIndex = 0;
    [SerializeField] int currentSubStepCount = 0;
    [SerializeField] int totalSteps;

    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    //public Image refImage;
    public VideoPlayer videoPlay;

    public AudioSource audioSource;
    public AudioClip stepCompleteClip;

    private void Start()
    {
        totalSteps = steps.Length;
        currentSubStepCount= 0;
        steps[0].CustomStart();
        totalSubSteps = steps[currentStepIndex].totalSubSteps;
        LoadUI();
    }

    private void OnEnable()
    {
        EventManager.stepCompleteEvent += NextStep;
    }

    private void OnDisable()
    {
        EventManager.stepCompleteEvent -= NextStep;

    }
    void NextStep()
    {
        if (currentStepIndex <= totalSteps)
        {
            totalSubSteps = steps[currentStepIndex].totalSubSteps;
            currentSubStepCount++;
            if (currentSubStepCount == totalSubSteps)
            {
                steps[currentStepIndex].CustomOnDisable();
                currentStepIndex++;
                LoadUI();
                audioSource.clip = stepCompleteClip;
                audioSource.Play();
                StartCoroutine(DelayStart());

            }
        }

    }

    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(2f);
        steps[currentStepIndex].CustomStart();
        currentSubStepCount = 0;
    }

    private void Update()
    {
        if(currentStepIndex <= totalSteps)
            steps[currentStepIndex].CustomUpdate();
    }

    void LoadUI()
    {
        titleText.text = steps[currentStepIndex].content.title; 
        descriptionText.text = steps[currentStepIndex].content.description; 
        //refImage.sprite = steps[currentStepIndex].content.refImage; 
        videoPlay.clip = steps[currentStepIndex].content.videoClip; 
    }
}
