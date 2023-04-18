using UnityEngine;
using UnityEngine.UI;

public class LookMoveTo : MonoBehaviour
{
    public GameObject ground;

    public Transform infoBubble;
    private Text infoText;

    void Update()
    {
        Ray ray;
        RaycastHit hit;

        GameObject hitObject;

        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100.0f);
        ray = new Ray(camera.position, camera.rotation * Vector3.forward);

        if (Physics.Raycast(ray, out hit))
        {
            hitObject = hit.collider.gameObject;
            if (hitObject == ground)
            {
                if(infoBubble != null)
                {
                    infoText.text = "X:" + hit.point.x.ToString("F2") + ", " + "Z:" + hit.point.z.ToString("F2");
                    infoBubble.LookAt(camera.position);
                    infoBubble.Rotate(0, 180f, 0);
                }
                Debug.Log("Hit (x,y,z): " + hit.point.ToString("F2"));
                transform.position = hit.point;
            }
        }
    }

    private Transform camera;

    void Start()
    {
        camera = Camera.main.transform;

        if (infoBubble != null)
        {
            infoText = GetComponentInChildren<Text>();
        }
    }
}
