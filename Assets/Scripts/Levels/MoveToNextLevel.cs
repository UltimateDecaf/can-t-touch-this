using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Created by Lari Basangov
 * 
 * This script moves player to the next level or the game over screen.
 */
public class MoveToNextLevel : MonoBehaviour
{
    [SerializeField] private int nextLevelNumber;

    private string finalLevel = "Level4";
    private string congratulationsScene = "GameFinished";
    private string nextLevel;


    private void Start()
    {
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
        
        if (currentSceneName.Equals(finalLevel)) 
        {
            nextLevel = congratulationsScene;
        }
        else
        {
            nextLevel = "Level" + nextLevelNumber;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioManager.Instance.PlayLevelPassSound();
        SceneManager.LoadScene(nextLevel);
    }
}
