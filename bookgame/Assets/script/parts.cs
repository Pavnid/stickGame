using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parts : MonoBehaviour
{
    // Array to hold the child GameObjects representing dice numbers
    public GameObject[] diceNumberObjects = new GameObject[5]; // assuming you have 5 child objects

    // Count for each dice number
    private int[] counts = new int[5];

    // Prefabs for body parts
    public GameObject headPrefab;
    public GameObject bodyPrefab;
    public GameObject legsPrefab;
    public GameObject handsPrefab;

    // Method to handle the player's turn
    public void PlayerTurn(int diceResult)
    {
        // Increment the count for the corresponding dice number
        counts[diceResult / 2]++;

        // Get the index of the child GameObject corresponding to the dice number
        int index = diceResult / 2;

        // Get the count for the current dice number
        int currentCount = counts[index];

        // Check the current count and display the corresponding body part prefab
        switch (currentCount)
        {
            case 1:
                InstantiatePrefab(headPrefab, diceNumberObjects[index]);
                break;
            case 2:
                InstantiatePrefab(bodyPrefab, diceNumberObjects[index]);
                break;
            case 3:
                InstantiatePrefab(legsPrefab, diceNumberObjects[index]);
                break;
            case 4:
                InstantiatePrefab(handsPrefab, diceNumberObjects[index]);
                break;
                // Add more cases as needed
        }
    }

    // Method to instantiate a body part prefab as a child of the specified dice number object
    // Method to instantiate a body part prefab as a child of the specified dice number object
    private void InstantiatePrefab(GameObject prefab, GameObject parentObject)
    {
        if (prefab != null && parentObject != null)
        {
            // Destroy any existing child objects
            foreach (Transform child in parentObject.transform)
            {
                Destroy(child.gameObject);
            }

            // Instantiate the prefab as a child of the specified dice number object
            GameObject bodyPartInstance = Instantiate(prefab, parentObject.transform.position, Quaternion.identity);
            bodyPartInstance.transform.SetParent(parentObject.transform);

            // Log a debug message indicating that the prefab was created
            Debug.Log(prefab.name + " prefab created as a child of " + parentObject.name);
        }
    }

}