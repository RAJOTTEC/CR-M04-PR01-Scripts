using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeController : MonoBehaviour
{
    public GameObject topBlade;
    public GameObject bottomBlade;

    private Rigidbody rb;

    public void activate()
    {
        topBlade.SetActive(true);
        bottomBlade.SetActive(true);
    }

    public void deactivate()
    {
        topBlade.SetActive(false);
        bottomBlade.SetActive(false);
    }
}
