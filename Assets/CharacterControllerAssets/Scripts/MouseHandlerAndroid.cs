﻿using UnityEngine;

public class MouseHandlerAndroid : MonoBehaviour
{
    // horizontal rotation speed
    public FloatingJoystick floatingJoystick;
    public float horizontalSpeed = 1f;
    // vertical rotation speed
    public float verticalSpeed = 1f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        float mouseX = floatingJoystick.Horizontal * horizontalSpeed;
        float mouseY = floatingJoystick.Vertical * verticalSpeed;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }
}
