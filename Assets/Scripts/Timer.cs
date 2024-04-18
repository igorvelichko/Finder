using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private int sec;
    [SerializeField] private int min;
    public static TMP_Text timer;
    [SerializeField] private int delta;

    void Start()
    {
        timer = GameObject.Find("TimerText").GetComponent<TMP_Text>();
        StartCoroutine(TimeScaler());
    }

    IEnumerator TimeScaler()
    {
        while(true)
        {
            if(sec == 0)
            {
                min--;
                sec = 60;
            }
            sec -= delta;
            timer.text = min.ToString("D2") + ':' + sec.ToString("D2");
            yield return new WaitForSeconds(1f);
        }
    }
}
