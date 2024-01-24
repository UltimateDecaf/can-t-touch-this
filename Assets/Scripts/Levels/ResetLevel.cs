using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Created by Lari Basangov
 * 
 * This script resets level (player appears at spawn position, and keys are reset).
 * It also shows fail animation and plays the fail sound (this could be a separate script).
 */
public class ResetLevel : MonoBehaviour 
{
    [SerializeField] private Transform playerSpawnPoint;
    [SerializeField] private GameObject floatingTextPrefab;
    private GameObject[] keys;

    private void Start()
    {
        keys = GameObject.FindGameObjectsWithTag("Key");
        Debug.Log(keys.Length);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = playerSpawnPoint.position;
            if(keys != null)
            {
                ResetKeys();
            }
            FailsTracker.Instance.IncrementFail();
            ShowFailText();
            AudioManager.Instance.PlayFailsSound();
            collision.gameObject.SetActive(true);

        }
    }

    private void ResetKeys() 
    {
        for(int i = 0; i < keys.Length; i++) 
        {
            keys[i].SetActive(true);
        }
    }

    void ShowFailText()
    {
        if (floatingTextPrefab)
        {
            GameObject prefab = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
            prefab.GetComponentInChildren<TextMesh>().text = "+1 FAIL";
        }
    }
}

