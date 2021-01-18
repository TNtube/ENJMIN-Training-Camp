using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHovering : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text theText;
    public Color baseColor;
    public Color hoveringColor;

    public void OnPointerEnter(PointerEventData eventData)
    {
        theText.color = hoveringColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        theText.color = baseColor;
    }
}