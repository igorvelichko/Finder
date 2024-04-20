using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Click : MonoBehaviour, IPointerClickHandler
{
    
    public static int countfind = 0;
    [SerializeField] private GameObject[] findnt;
    [SerializeField] private Button[] findntbut;
    [SerializeField] private GameObject[] particlesup;
    [SerializeField] private GameObject[] particlesdown;

    public void OnPointerClick(PointerEventData eventData)
    {
        countfind++;
        eventData.rawPointerPress.SetActive(false);
        for(int i = 0; i < findntbut.Length; i++)
        {
            if(eventData.rawPointerPress.tag == findntbut[i].tag)
            {
                findntbut[i].interactable = false;
                StartCoroutine(Particle(i));
            }
        }
    }

    public void ClickBack(int index)
    {
        countfind++;
        
        EndAnim(index);


    }

    public void EndAnim(int index)
    {
        StartCoroutine(Particle(index-1));
        findnt[index - 1].SetActive(false);
        findntbut[index - 1].interactable = false;
    }

    IEnumerator Particle(int index)
    {
        particlesup[index].SetActive(true);
        particlesdown[index].SetActive(true);
        yield return new WaitForSeconds(3f);
        particlesup[index].SetActive(false);
        particlesdown[index].SetActive(false);
    }
}
