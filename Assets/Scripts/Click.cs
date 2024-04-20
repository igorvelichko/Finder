using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IPointerClickHandler
{
    
    public static int countfind = 0;
    [SerializeField] private GameObject[] findnt;
    [SerializeField] private Button[] findntbut;

    public void OnPointerClick(PointerEventData eventData)
    {
        countfind++;
        eventData.rawPointerPress.SetActive(false);
        for(int i = 0; i < findntbut.Length; i++)
        {
            if(eventData.rawPointerPress.tag == findntbut[i].tag)
            {
                findntbut[i].interactable = false;
            }
        }
    }

    public void ClickBack(int index)
    {
        countfind++;
        findnt[index - 1].SetActive(false);
        findntbut[index - 1].interactable = false;
    }
}
