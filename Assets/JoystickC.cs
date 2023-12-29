using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickC : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    [HideInInspector] public bool isPressing;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressing = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressing = false;
    }


}
