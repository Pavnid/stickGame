using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DiceRoll : MonoBehaviour
{
    // Array to hold the sides of the dice
    private int[] sides = { 2, 4, 6, 8, 0 };

    // Function to roll the dice and return the result
    private int RollDice()
    {
        // Get a random index within the range of the sides array
        int randomIndex = Random.Range(0, sides.Length);

        // Return the value at the randomly selected index
        return sides[randomIndex];
    }

    // Detect collision with another GameObject
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collision is with a GameObject that has a tag "RollTrigger"
        if (other.CompareTag("RollTrigger"))
        {
            // Roll the dice and print the result
            int result = RollDice();
            Debug.Log("You rolled a " + result);
        }
    }
}