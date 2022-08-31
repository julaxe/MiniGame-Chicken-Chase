using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    private float fSteps = 0.1f;

    [SerializeField]
    private float fCurrentScale;

    [SerializeField]
    private float fMaxTimeScale = 3f;

    // Update is called once per frame
    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if(Time.timeScale < fMaxTimeScale)
        {
            if(Time.timeScale < 2.0f)
            {
                Time.timeScale += fSteps * Time.deltaTime;
            }
            else
            {
                Time.timeScale += fSteps*0.5f * Time.deltaTime; //grow half the speed
            }

            fCurrentScale = Time.timeScale;
        }
    }
}
