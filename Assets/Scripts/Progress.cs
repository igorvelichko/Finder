using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;

public class Progress : MonoBehaviour
{
    public static int lvlcount = 1;
    [SerializeField]private int findnt;
    private TMP_Text find_text;
    private TMP_Text lvl;
    

    private void Start()
    {
        find_text = GameObject.Find("Progress").GetComponent<TMP_Text>();
        lvl = GameObject.Find("Lvl").GetComponent<TMP_Text>();
        lvlcount = PlayerPrefs.GetInt("Lvl");
    }

    private void Update()
    {
        OffBut();
    }

    public void LvL()
    {
        lvl.text = "Уровень: " + lvlcount;
    }

    public void FindedText()
    {
        find_text.text = Click.countfind + "/" + findnt;
 
    }

    public void OffBut()
    { 
        FindedText();
        LvL();
    }
}
