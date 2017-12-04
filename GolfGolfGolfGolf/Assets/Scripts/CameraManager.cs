using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform centrTarget;

    Vector3 lastMousePosition = Vector2.zero;
    Vector3 mouseDelta = Vector2.zero;

    float mouseSpeed = 10;
    float scrollSpeed = 60;
    
    void Update ()
    {
        transform.parent.parent.position = centrTarget.position;

        mouseDelta = lastMousePosition - Input.mousePosition;
        lastMousePosition = Input.mousePosition;
        if (Input.GetMouseButton(2))
        {
            transform.parent.Rotate(new Vector3(mouseDelta.y, 0, 0) * Time.deltaTime * mouseSpeed);
            transform.parent.parent.Rotate(new Vector3(0, -mouseDelta.x, 0) * Time.deltaTime * mouseSpeed);
        }

        if(Input.mouseScrollDelta != Vector2.zero)
        {
            Camera.main.fieldOfView -= Input.mouseScrollDelta.y * Time.deltaTime * scrollSpeed;
        }
	}
}
