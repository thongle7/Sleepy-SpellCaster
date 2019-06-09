using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GoalButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    public GameObject highlighted;
    public GameObject hideText;
    public GameObject showText;
    public GameObject hideBack;
    public GameObject showBack;
    public GameObject showButton;


    public void OnPointerEnter(PointerEventData eventData)
    {
        highlighted.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        highlighted.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        hideText.SetActive(false);
        showText.SetActive(true);
        hideBack.SetActive(false);
        showBack.SetActive(true);
        showButton.SetActive(true);       
    }
}
