using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Created by Lari Basangov
 *
 * This script keeps track of all keys (yellow circles) present in the level.
 * When all keys are collected, goal collider is enables, so that player can advance 
 * to the next level.
 */
public class KeyTracker : MonoBehaviour
{
    int currentKeysInLevel;
    [SerializeField] BoxCollider2D goalCollider;

    // Start is called before the first frame update
    void Start()
    {
        currentKeysInLevel = GameObject.FindGameObjectsWithTag("Key").Length;
    }

    // Update is called once per frame
    void Update()
    {
        currentKeysInLevel = GameObject.FindGameObjectsWithTag("Key").Length;
        if (currentKeysInLevel <= 0) 
        {
            goalCollider.enabled = true;
        }
    }
}
