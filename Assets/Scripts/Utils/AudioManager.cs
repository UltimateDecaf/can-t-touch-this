using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by Lari Basangov

// This script initiates an Audio Manager, when main menu is loaded, and then other scripts
// use these methods to play sounds, when needed
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip backgroundMusic;
    [SerializeField] private AudioClip failSound;
    [SerializeField] private AudioClip levelPassSound;
    [SerializeField] private AudioClip gameOverSound;

    private void Start()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    public void PlayFailsSound()
    {
        audioSource.PlayOneShot(failSound);
    }

    public void PlayLevelPassSound()
    {
        audioSource.PlayOneShot(levelPassSound);
    }

    public void PlayGameOverSound() 
    {
        audioSource.PlayOneShot(gameOverSound);
    }
    

}
