using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PopUp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMesh text;
    public void OnPointerEnter(PointerEventData eventData)
    {
        text.text = $"{name} ";
        print($" {name} ");
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        text.text = $" ";
        print($" ");
    }
}
