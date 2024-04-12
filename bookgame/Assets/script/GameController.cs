using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    public GameObject[] players; // Array of player GameObjects
    public Text resultText; // Text component to display the result
    public Button rollButton; // Button to roll the dice

    private int currentPlayerIndex = 0; // Index of the current player
    private int[] possibleRolls = { 0, 2, 4, 6, 8 }; // Possible roll results
    private int playersCompletedTurn = 0; // Number of players who completed their turns in a round

    private void Start()
    {
        // Start the first player's turn
        StartPlayerTurn();
    }

    // Method to start a player's turn
    
    private void StartPlayerTurn()
    {
        // Check if the rollButton reference is null
        if (rollButton == null)
        {
            Debug.LogError("Roll button reference is null!");
            return;
        }

        // Enable the roll button for the current player's turn
        rollButton.interactable = true;

        // Display whose turn it is
        resultText.text = players[currentPlayerIndex].name + "'s turn";
    }

    // Method to roll the dice
    public void RollDice()
    {
        // Choose a random roll result from the possible rolls
        int resultIndex = Random.Range(0, possibleRolls.Length);
        int result = possibleRolls[resultIndex];

        // Display the result
        resultText.text = "Player " + players[currentPlayerIndex].name + " rolled: " + result;

        // Call the StartPlayerTurn method of the PlayerController with the dice result
        players[currentPlayerIndex].GetComponent<PlayerController>().StartPlayerTurn(result);
    

        // Check if the result is one of the desired numbers

        // if (result != 2 && result != 4 && result != 6 && result != 8 && result != 0)
        // {
        //     Debug.LogWarning("Invalid dice roll result: " + result);
        // }

        // Display the result
        resultText.text = players[currentPlayerIndex].name + " rolled: " + result;

        // Move to the next player's turn
        //StartCoroutine(NextPlayerTurn());
    }


    // Method to move to the next player's turn after a delay
    private IEnumerator NextPlayerTurn()
    {
        yield return new WaitForSeconds(0.1f); // Delay before the next player's turn

        // Increment the number of players who completed their turns
        playersCompletedTurn++;

        // If all players have completed their turns, reset the count and start a new round
        if (playersCompletedTurn == players.Length)
        {
            playersCompletedTurn = 0; // Reset the count
            currentPlayerIndex = 0; // Start from the first player for the new round
        }
        else
        {
            // Move to the next player
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;
        }

        // Start the next player's turn
        StartPlayerTurn();
    }

    public void KillOponent()
    {
        Debug.Log("came in kill oponent");
        if (currentPlayerIndex == 0)
        {
            GameObject player2 = GameObject.Find("player2");
             for (int i = 0; i < 9; i += 2)
            {
                string childName = "stick" + i.ToString(); // Generating child name dynamically
                Transform childTransform = player2.transform.Find(childName);
                // if (childTransform != null)
                // {
                //GameObject childGameObject = childTransform.gameObject;
                
                BoxCollider2D collider = childTransform.GetComponent<BoxCollider2D>();
                // if (collider != null)
                // {
                    // Enable the BoxCollider
                    collider.enabled = true;
                    Debug.Log("box collider of " + childName + "is activated");
                // }
            }
            // else
            // {
            //     Debug.LogWarning("Child GameObject '" + childName + "' not found!");
            //     continue;
            // }
        }
        // else if (currentPlayerIndex == 1)
        // {
        //     GameObject player3 = GameObject.Find("player3");
        //     Destroy(player3);
        // }
        // else if (currentPlayerIndex == 2)
        // {
        //     GameObject player1 = GameObject.Find("Player1");
        //     Destroy(player1);
        // }
        }
    //}


    // Method to notify that the player's move is completed
    public void PlayerMoveCompleted()
    {
        // Decrement the number of players who completed their turns
        //playersCompletedTurn++;

        // If all players have completed their turns, start the next round
        // if (playersCompletedTurn == 0)
        // {
            StartCoroutine(NextPlayerTurn());
        // }
    }

}
