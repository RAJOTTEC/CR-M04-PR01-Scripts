using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAfterDelay : MonoBehaviour
{
    public float delayInSeconds = 5f;
    public float fadeRate = 0.25f;

    private CanvasGroup canvasGroup;
    private float startTimer;
    private float fadeoutTimer;

    void OnEnable()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1f;

        startTimer = Time.time + delayInSeconds;
        fadeoutTimer = fadeRate;
    }

    void Update()
    {
        if(Time.time >= startTimer)
        {
            fadeoutTimer -= Time.deltaTime;

            if(fadeoutTimer <= 0)
            {
                gameObject.SetActive(false);
            }
            else
            {
                canvasGroup.alpha = fadeoutTimer / fadeRate;
            }
        }
    }
}
