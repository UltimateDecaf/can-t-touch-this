using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/* Created by Lari Basangov
 * 
 * This script enables and disables a trap, if needed.
 * Works well for traps that do not move.
 */
public class TrapBlinker : MonoBehaviour
{
    [SerializeField] private bool useBlinker;
    [SerializeField] private float interval;
    [SerializeField] private bool initiallyActive;

    private bool trapIsActive;
    private readonly string trapStateMethod = "HandleTrapState";

    [SerializeField] private CircleCollider2D circleCollider;
    [SerializeField] private GameObject border;
    [SerializeField] private GameObject fill;

   

    private void Start()
    {
        if (!useBlinker)
        {
            return;
        }
        trapIsActive = initiallyActive;
        InvokeRepeating(trapStateMethod, 0, interval);

    }

   
    private void HandleTrapState() 
    {
        if (trapIsActive)
        {
            circleCollider.enabled = false;
            border.SetActive(false);
            fill.SetActive(false);
            trapIsActive = false;
        }
        else
        {
            circleCollider.enabled = true;
            border.SetActive(true);
            fill.SetActive(true);
            trapIsActive = true;
        }
    }
}
