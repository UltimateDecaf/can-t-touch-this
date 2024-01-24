using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TrapMovement : MonoBehaviour
{
    [Header("Choose only one option")]
    [SerializeField] private bool horizontalMove;
    [SerializeField] private bool verticalMove;
    [SerializeField] private bool rotatingMove;
    [SerializeField] private bool parentRotator;

    [Header("Values")]
    [SerializeField] private float moveSpeed;

    [Header("For Horizontal/Vertical Movement")]
    [SerializeField] private float limitValue;
    [SerializeField] private bool StartWithNegative;

    [Header("For Rotating Movement / Parent Rotator")]
    [SerializeField] private bool moveClockwise;
    [SerializeField] private float rotationValue;

    void Start()
    {
        InitialDirectionCheck();
    }

    
    void FixedUpdate()
    {
        MoveTrap();
    }

    void MoveTrap()
    {
        if (horizontalMove) 
        {
            transform.Translate(moveSpeed, 0, 0);
            if((transform.position.x >= 0 && transform.position.x > limitValue) ||  (transform.position.x < 0 && transform.position.x < -(limitValue)))
            {
                moveSpeed = -moveSpeed;
            }
        }
        else if (verticalMove)
        {
            transform.Translate(0, moveSpeed, 0);
            if ((transform.position.y >= 0 && transform.position.y > limitValue) || (transform.position.y < 0 && transform.position.y < -(limitValue)))
            {
                moveSpeed = -moveSpeed;
            }
        } else if (rotatingMove)
        {
            if (!parentRotator)
            {
                transform.Translate(moveSpeed, 0, 0);
                transform.Rotate(0, 0, rotationValue);
            }
            else
            {
                transform.Rotate(0, 0, rotationValue * moveSpeed);
            }
        }
    }

    void InitialDirectionCheck()
    {
        if (StartWithNegative)
        {
            moveSpeed = -moveSpeed;
        }

        if(moveClockwise)
        {
            rotationValue = -rotationValue;
        }
    }
}
