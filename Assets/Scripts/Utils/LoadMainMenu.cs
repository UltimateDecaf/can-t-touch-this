using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Created by Lari Basangov

// This script loads the Main Menu scene in the very beginning after the disclaimer is shown
public class LoadMainMenu : MonoBehaviour
{

    private string mainMenu = "MainMenu";
    [SerializeField] private float delayTime;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMenuScene", delayTime);
    }

    private void LoadMenuScene()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
