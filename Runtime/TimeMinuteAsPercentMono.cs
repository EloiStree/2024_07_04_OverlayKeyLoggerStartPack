using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeMinuteAsPercentMono : MonoBehaviour
{

    public UnityEvent<float> m_onMinuteAsPercentChanged;
   
    void Update()
    {
        DateTime now= DateTime.Now;
        float minuteAsPercent = (float)now.Second / 60.0f;
        m_onMinuteAsPercentChanged.Invoke(minuteAsPercent);
    }
}
