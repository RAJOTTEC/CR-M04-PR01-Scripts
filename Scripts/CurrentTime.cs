using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class CurrentTime : MonoBehaviour
{
    [SerializeField] TMP_Text currentTime;

    void Update()
    {
        currentTime.text = DateTime.Now.ToString();
    }
}