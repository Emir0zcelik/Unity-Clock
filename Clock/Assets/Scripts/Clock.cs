using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private const float hoursToDegrees = -30f;
    private const float minutesToDegrees = -6f;
    private const float secondsToDegrees = -6f;
    
    [SerializeField] private Transform hourPivot;
    [SerializeField] private Transform minutePivot;
    [SerializeField] private Transform secondPivot;

    private void Awake()
    {
        DateTime time = DateTime.Now; 
        
        hourPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * time.Hour);
        minutePivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * time.Minute);
        secondPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * time.Second);
    }

    private void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        
        hourPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float)time.TotalHours);
        minutePivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * (float)time.TotalMinutes);
        secondPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * (float)time.TotalSeconds);
    }
}
