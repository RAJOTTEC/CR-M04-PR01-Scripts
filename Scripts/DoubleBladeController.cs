using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBladeController : MonoBehaviour
{
    public GameObject topBladePrefab;
    public GameObject bottomBladePrefab;
    private GameObject blade;

    private Rigidbody rb;

    public void activate()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
    }

    public void deactivate()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }
}
