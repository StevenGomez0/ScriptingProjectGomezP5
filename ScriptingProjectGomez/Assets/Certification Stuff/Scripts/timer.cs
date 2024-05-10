using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timerTime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", 0, 1);
        timerTime = 60;
    }

    void Timer()
    {
        timerTime -= 1;
        timerText.text = ("Time Left: " + timerTime);
        if (timerTime == 0)
        {
            CancelInvoke("Timer");
        }
    }
}
