using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextColorChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    TextMeshProUGUI tMPro_Text;
    public Color color = new Color(99f,147f,147f,255f);
    void Start()
    {
        tMPro_Text = GetComponent<TextMeshProUGUI>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        tMPro_Text.color = Color.white;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        ResetColor();
    }

    public void ResetColor()
    {
        tMPro_Text.color = color;
    }
}
