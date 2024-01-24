using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Created by Lari Basangov
 * 
 * This script disables the key's gameObject and plays the sound.
 */
public class KeyBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.Instance.PlayLevelPassSound();
            this.gameObject.SetActive(false);
        }
    }
}
