using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotationSpeed = 500.0f;
    private Vector3 mouseWorldPoitionStart;
    public float zoomScale = 10.0f;
    public float zoomMin = 0.1f;
    public float zoomMax = 10.0f;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Mouse2))
        {
            CameraOrbit();
        }

        if (Input.GetMouseButtonDown(2) && !Input.GetKey(KeyCode.LeftShift))
        {
            mouseWorldPoitionStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }

        if (Input.GetMouseButton(2) && !Input.GetKey(KeyCode.LeftShift))
        {
            Pan();
        }

        Zoom(Input.GetAxis("Mouse ScrollWheel"));

    }

    void CameraOrbit()
    {
        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            float verticalInput = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            float horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward, -verticalInput);
            transform.Rotate(Vector3.right, -horizontalInput);
        }
    }

    void Pan()
    {
        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            Vector3 mouseWorldPositionDif = mouseWorldPoitionStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position += mouseWorldPositionDif;
        }
    }

    void Zoom(float zoomDifference)
    {
        if (zoomDifference != 0)
        {
            mouseWorldPoitionStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - zoomDifference * zoomScale, zoomMin, zoomMax);
            Vector3 mouseWorldPositionDif = mouseWorldPoitionStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position += mouseWorldPositionDif;
        }
    }
}
