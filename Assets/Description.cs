using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Description : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler {

    public GameObject spellDescription;

    public void OnPointerEnter(PointerEventData eventData)
    {
        spellDescription.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        spellDescription.SetActive(false);
    }
}
