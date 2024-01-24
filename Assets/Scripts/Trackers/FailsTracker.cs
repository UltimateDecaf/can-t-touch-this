using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Created by Lari Basangov
 * 
 * This script handles logic for updating the number of fails,
 * as well as sharing them with other scripts.
 * 
 * This script DOES NOT store the fails, it is done in a Singleton object GameData.
 */

public class FailsTracker : MonoBehaviour
{
    public static FailsTracker Instance;
    private int fails;
    void Start()
    {
        Instance = this;
        if (GameData.Fails <= 0)
        {
            fails = 0;
        }
        else 
        {
            fails = GameData.Fails;
        };
    }

    public void IncrementFail() 
    {
        fails++;
        GameData.Fails = fails;
    }

    public int GetFails() 
    {
        return fails;
    }

    public void NullifyFails()
    {
        GameData.Fails = 0;
    }
}
