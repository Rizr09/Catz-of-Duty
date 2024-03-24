using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;
    public float thresholdRotationX = 90f;
    public float thresholdRotationY = 90f;

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;

        rotationX = Mathf.Clamp(rotationX, -thresholdRotationX, thresholdRotationX);
        rotationY = Mathf.Clamp(rotationY, -thresholdRotationY, thresholdRotationY);

        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
