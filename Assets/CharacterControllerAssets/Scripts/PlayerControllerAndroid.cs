﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerAndroid : MonoBehaviour
{
    public FloatingJoystick floatingJoystick;
    CharacterController characterController;
    public float MovementSpeed = 1;
    public float Gravity = 9.8f;
    private float velocity = 0;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // player movement - forward, backward, left, right
        float horizontal = floatingJoystick.Horizontal * MovementSpeed;
        float vertical = floatingJoystick.Vertical * MovementSpeed;
        characterController.Move((transform.right * horizontal + transform.forward * vertical) * Time.deltaTime);

        // Gravity
        if (characterController.isGrounded)
        {
            velocity = 0;
        }
        else
        {
            velocity -= Gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, velocity, 0));
        }
    }
}
