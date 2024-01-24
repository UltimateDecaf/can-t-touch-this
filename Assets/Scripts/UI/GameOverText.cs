using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

/* Created by Lari Basangov
 *
 * This script shows the appropriate text in 'Game Over' scene 
 * based on the number of fails
 */
public class GameOverText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI congratulationText;
    private int fails;
    // Start is called before the first frame update
    void Start()
    {
        fails = FailsTracker.Instance.GetFails();
        ShowCongratulationText();
    }

    void ShowCongratulationText()
    {
        if(fails >= 10)
        {
            congratulationText.text = "You have completed all 4 levels! \r\nYou failed " + fails + " times. Try again with less fails!";

        }
        else if (fails > 1 && fails < 10)
        {
            congratulationText.text = "Great job! Only " + fails + " fails! \r\nWould you dare to try a perfect run?";
        }
        else if (fails == 1)
        {
            congratulationText.text = "Great job! Only 1 fail! \r\nWould you dare to try a perfect run?";
        }
        else if (fails >= 0)
        {
            congratulationText.text = "You are the one! There is no one like you! \r\nThank you for spending the time to play!\r\nZERO FAILS! ZERO!";
        }

        //TODO: Move this line of code to a different script, as this script deals with Game Over text only
        FailsTracker.Instance.NullifyFails();
    }
}
