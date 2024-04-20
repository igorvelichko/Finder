using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public static int sec;
    [SerializeField] private int min;
    private TMP_Text timer;
    [SerializeField] private int delta;
    public static string time;
    

    void Start()
    {
        timer = GameObject.Find("TimerText").GetComponent<TMP_Text>();
        StartCoroutine(TimeScaler());
        
    }

    private void Update()
    {
        time = timer.text;
        
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
            if (sec > 60)
            {
                min++;
                sec -= 60;
            }
            sec -= delta;
            timer.text = min.ToString("D2") + ":" + sec.ToString("D2");
            yield return new WaitForSeconds(1f);
        }
    }
}
