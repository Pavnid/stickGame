using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerRoundManager : MonoBehaviour
{
    public GameObject[] players; // Array to store player GameObjects

    private int currentPlayerIndex = 0; // Index of the current player

    private void Start()
    {
        StartNextRound();
    }

    private void StartNextRound()
    {
        // Check if there are any players in the array
        if (players.Length == 0)
        {
            Debug.LogError("No players found. Make sure to assign player GameObjects to the PlayerRoundManager.");
            return;
        }

        Debug.Log("Player " + (currentPlayerIndex + 1) + "'s turn.");
        // You can put any logic here for starting a player's turn, like enabling UI elements for rolling the dice.

        // Activate the current player's GameObject
        players[currentPlayerIndex].SetActive(true);
    }

    public void EndCurrentRound()
    {
        // Deactivate the current player's GameObject
        players[currentPlayerIndex].SetActive(false);

        // Move to the next player
        currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;

        // Check if all players have finished their rounds
        if (currentPlayerIndex == 0)
        {
            Debug.Log("All players have finished their rounds. Starting a new round.");
        }

        StartNextRound();
    }

    // Method to get the index of the current player
    public int GetCurrentPlayerIndex()
    {
        return currentPlayerIndex;
    }
}