using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocity = 0.2f;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*velocity, 0, Input.GetAxis("Vertical")*velocity);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        cam.transform.Rotate(Input.GetAxis("Mouse Y")*-1, 0, 0);
    }
}
