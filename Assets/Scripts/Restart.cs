using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    private GameObject BackImage;
    private readonly Timer timer;
    private TMP_Text time;


    private void Start()
    {
        time = timer.GetComponent<TMP_Text>();
    }

    void Update()
    {
        if(time.text == "00:00")
        {
            BackImage.SetActive(true);
        }
    }

    public void Rest()
    {
        SceneManager.LoadScene(0);
    }
}
