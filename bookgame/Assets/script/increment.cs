using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers

public class PlayerController : MonoBehaviour
{
    // Count variables for each dice number
    public int count0 = 0;
    public int count2 = 0;
    public int count4 = 0;
    public int count6 = 0;
    public int count8 = 0;
    //bullets
    private int bullet = 0;
    // Reference to the GameController script
    public GameController gameController;

    // Reference to the UI Text components to display the counts
    public Text count0Text;
    public Text count2Text;
    public Text count4Text;
    public Text count6Text;
    public Text count8Text;
    //body part image


    // Method to handle the player's turn
    public void StartPlayerTurn(int result)
    {
        Debug.Log("StartPlayerTurn called with result: " + result);

        switch (result)
        {
            case 0:

                count0++;
                //count0Text.text = "Count 0: " + count0;
                if (count0 == 1)
                {
                    count0Text.text = "head";
                    count0Text.color = Color.red;

                    // Add your message or action here
                }
                else if (count0 == 2)
                {
                    count0Text.text = "body";
                    count0Text.color = Color.blue;
                    // Add your message or action here
                }
                else if (count0 == 3)
                {
                    count0Text.text = "legs";
                    count0Text.color = Color.green;
                    // Add your message or action here
                }
                else if (count0 == 4)
                {
                    count0Text.text = "hands";
                    count0Text.color = Color.yellow;
                    // Add your message or action here
                }
                else if (count0 == 5)
                {
                    count0Text.text = "GUN";
                    count0Text.color = Color.red;
                    // Add your message or action here
                }
                else if (count0 == 6)
                {
                    count0Text.text = "...BULLETS...";
                    count0Text.color = Color.red;
                    gameController.KillOponent();
                    // Add your message or action here
                }

                break;
            case 2:
                count2++;
                if (count2 == 1)
                {
                    count2Text.text = "head";
                    count2Text.color = Color.red;
                    // Add your message or action here
                }
                else if (count2 == 2)
                {
                    count2Text.text = "body";
                    count2Text.color = Color.blue;
                    // Add your message or action here
                }
                else if (count2 == 3)
                {
                    count2Text.text = "legs";
                    count2Text.color = Color.green;
                    // Add your message or action here
                }
                else if (count2 == 4)
                {
                    count2Text.text = "hands";
                    count2Text.color = Color.yellow;
                    // Add your message or action here
                }
                else if (count0 == 5)
                {
                    count2Text.text = "GUN";
                    count2Text.color = Color.red;
                    // Add your message or action here
                }
                else if (count0 == 6)
                {
                    count2Text.text = "...BULLETS...";
                    count2Text.color = Color.red;
                    gameController.KillOponent();
                    // Add your message or action here
                }
                break;
            case 4:
                count4++;
                if (count4 == 1)
                {
                    count4Text.text = "head";
                    count4Text.color = Color.red;
                    // Add your message or action here
                }
                else if (count4 == 2)
                {
                    count4Text.text = "body";
                    count4Text.color = Color.blue;
                    // Add your message or action here
                }
                else if (count4 == 3)
                {
                    count4Text.text = "legs";
                    count4Text.color = Color.green;
                    // Add your message or action here
                }
                else if (count4 == 4)
                {
                    count4Text.text = "hands";
                    count4Text.color = Color.yellow;
                    // Add your message or action here
                }
                else if (count0 == 5)
                {
                    count4Text.text = "GUN";
                    count4Text.color = Color.red;
                    // Add your message or action here
                }
                else if (count0 == 6)
                {
                    count4Text.text = "...BULLETS...";
                    count4Text.color = Color.red;
                    gameController.KillOponent();
                    // Add your message or action here
                }
                break;
            case 6:
                count6++;
                if (count6 == 1)
                {
                    count6Text.text = "head";
                    count6Text.color = Color.red;
                    // Add your message or action here
                }
                else if (count6 == 2)
                {
                    count6Text.text = "body";
                    count6Text.color = Color.blue;
                    // Add your message or action here
                }
                else if (count6 == 3)
                {
                    count6Text.text = "legs";
                    count6Text.color = Color.green;
                    // Add your message or action here
                }
                else if (count6 == 4)
                {
                    count6Text.text = "hands";
                    count6Text.color = Color.yellow;
                    // Add your message or action here
                }
                else if (count0 == 5)
                {
                    count6Text.text = "GUN";
                    count6Text.color = Color.red;
                    // Add your message or action here
                }
                else if (count0 == 6)
                {
                    count6Text.text = "...BULLETS...";
                    count6Text.color = Color.red;
                    gameController.KillOponent();
                    // Add your message or action here
                }
                break;
            case 8:
                count8++;
                if (count8 == 1)
                {
                    count8Text.text = "head";
                    count8Text.color = Color.red;
                    // Add your message or action here
                }
                else if (count8 == 2)
                {
                    count8Text.text = "body";
                    count8Text.color = Color.blue;
                    // Add your message or action here
                }
                else if (count8 == 3)
                {
                    count8Text.text = "legs";
                    count8Text.color = Color.green;
                    // Add your message or action here
                }
                else if (count8 == 4)
                {
                    count8Text.text = "hands";
                    count8Text.color = Color.yellow;
                    // Add your message or action here
                }
                else if (count0 == 5)
                {
                    count8Text.text = "GUN";
                    count8Text.color = Color.red;
                    // Add your message or action here
                }
                else if (count0 == 6)
                {
                    count8Text.text = "...BULLETS...";
                    count8Text.color = Color.red;
                    gameController.KillOponent();
                    
                    // Add your message or action here
                }
                break;
            default:
                Debug.LogWarning("Invalid dice result: " + result);
                break;
        }

        //Debug.Log("Counts: 0-" + count0 + ", 2-" + count2 + ", 4-" + count4 + ", 6-" + count6 + ", 8-" + count8);

        gameController.PlayerMoveCompleted();
    }

    public void BulletIncrement()
    {
        if (count0 <5)
        {
            bullet = +2;
        }
        
    }
    public void KillChanceReduce()
    {
        bullet--;
    }
    public void NotAbleToKill()
    {
        if(bullet==0)
        {
            // disable stick for kill 
            
        }
    }
}
