using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public GameObject LozeImage;
    public GameObject WinImage;

    private void Start()
    {
        Time.timeScale = 1;
    }

    void LateUpdate()
    {
        if (Timer.time == "00:00")
            Restloze();
        else if (Click.countfind == 10)
            Restwin();
    }

    public void Restloze()
    {
        Time.timeScale = 0;

        LozeImage.SetActive(true);
    }

    public void Restwin()
    {
        Time.timeScale = 0;

        WinImage.SetActive(true);
    }

    public void RestBut()
    {
        SceneManager.LoadScene(0);
        Progress.lvlcount += 1;
        Click.countfind = 0;
        PlayerPrefs.SetInt("Lvl", Progress.lvlcount);
    }
}
