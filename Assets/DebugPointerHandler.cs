using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DebugPointerHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public Text _debugLabel;

    public void OnPointerDown(PointerEventData eventData)
    {
        _debugLabel.text = "Down!";
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _debugLabel.text = "Enter!";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _debugLabel.text = "Exit!";
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _debugLabel.text = "Up!";
    }
}
