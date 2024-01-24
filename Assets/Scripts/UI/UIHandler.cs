using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/* Created by Lari Basangov
 * 
 * This script updates the number of fails on the screen.
 */

public class UIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI FailsUI;
    [SerializeField] private TextMeshProUGUI LevelHeader;

    private void Start()
    {
        FailsUI.text = "Fails: 0";
    }

    private void Update()
    {
        UpdateFails();
    }
    void UpdateFails() 
    {
        FailsUI.text = "Fails: " + FailsTracker.Instance.GetFails(); 
    }
}
