using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    [NonSerialized] public GameObject twistedPlatform;

    [SerializeField]
    private float Radious;

    private float Speed;

    [SerializeField]
    private float RotationalSpeed;

    [SerializeField]
    private float InitialYValue;

    private float angle;
    private float Yposition;

    private double timer;



    void Start()
    {
        Reset();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Speed = RotationalSpeed / 13.89f; // try and error number - 50 R.S. /3.6 Speed
        angle += RotationalSpeed * Time.deltaTime;
        Yposition -= Speed * Time.deltaTime;
        CalculatePosition();
        CalculateLocalAngle();
        if (timer > 4)
        {
            //Reset();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void Reset()
    {
        angle = 0;
        Yposition = InitialYValue; // try and error number
        CalculatePosition();
    }

    private void CalculatePosition()
    {
        float x = twistedPlatform.transform.position.x + Radious * Mathf.Sin(Mathf.Deg2Rad * angle);
        float z = twistedPlatform.transform.position.z + Radious * Mathf.Cos(Mathf.Deg2Rad * angle);
        transform.position = new Vector3(x, Yposition, z);
    }
    private void CalculateLocalAngle()
    {
        transform.rotation = Quaternion.Euler(0, angle+90, 0);
    }
}
