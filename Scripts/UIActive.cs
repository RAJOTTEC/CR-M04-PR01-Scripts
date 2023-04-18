using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIActive : MonoBehaviour
{
    public GameObject hand;
    public GameObject UI;

    void Update()
    {
        if (hand.transform.rotation.y <= .4f && hand.transform.rotation.y >= -.6f && hand.transform.rotation.x <= .6f && hand.transform.rotation.x >= .4f)
        {
            UI.SetActive(true);
        }
        else
        {
            UI.SetActive(false);
        }
    }
}
