using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Created by Lari Basangov
 * 
 * This script can be attached to a GameObject that needs to be destroyed in a certain amount of seconds
 * In this project this script is used for the "+1 FAIL" animation.
 */

public class DestroyInSeconds : MonoBehaviour
{
    [SerializeField] private float secondsToDestroy;
    void Start()
    {
        Destroy(gameObject, secondsToDestroy);
    }
}
