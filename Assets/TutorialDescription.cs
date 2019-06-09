using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TutorialDescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler{

    public GameObject spellDescription;
    public GameObject hover;
    public GameObject cast;

    public void OnPointerEnter(PointerEventData eventData)
    {
        spellDescription.SetActive(true);
        hover.SetActive(false);
        cast.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        spellDescription.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        cast.SetActive(false);
    }
}
