using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCanvasEventCamera : MonoBehaviour
{
    void Start()
    {
        Canvas canvas = GetComponent<Canvas>();
        if(canvas && canvas.worldCamera == null)
        {
            canvas.worldCamera = Camera.main;
        }
    }
}
