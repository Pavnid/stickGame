using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickGeneration : MonoBehaviour
{
    public GameObject[] stickmanParts;
    public Transform[] player1Slots; // Slots for player 1
    public Transform[] player2Slots; // Slots for player 2
    public Transform[] player3Slots; // Slots for player 3
    private int currentPlayer = 0; // Variable to track current player
    private int currentPartIndex = 0; // Variable to track current stickman part index

    public void StartTurn(int diceNum)
    {
        // Determine current player's slots based on dice roll
        Transform[] currentPlayerSlots = GetCurrentPlayerSlots();

        // Place stickman part in the selected slot
        PlaceStickmanPart(currentPlayerSlots[diceNum / 2]);


    }

    Transform[] GetCurrentPlayerSlots()
    {
        switch (currentPlayer)
        {
            case 0:
                return player1Slots;
            case 1:
                return player2Slots;
            case 2:
                return player3Slots;
            default:
                return null;
        }
    }
}
