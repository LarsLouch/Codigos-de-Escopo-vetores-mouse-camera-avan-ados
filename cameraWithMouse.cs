using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraWithMouse : MonoBehaviour
{
    public float rotationSpeed;

    private void OnMouseDrag()
    {
        float Y = Input.GetAxis("Mouse Y") * rotationSpeed;
        float X = Input.GetAxis("Mouse X") * rotationSpeed;
        
        transform.Rotate(Vector3.right, Y);
        transform.Rotate(Vector3.up, -X);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
