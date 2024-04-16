using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private PlayerRoundManager roundManager;
    private int finalSide; // Declare finalSide as a class-level variable
    stickGeneration EmpGameObject;

    

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        roundManager = FindObjectOfType<PlayerRoundManager>(); // Find the PlayerRoundManager in the scene
    }

    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;

        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 4);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        finalSide = randomDiceSide + 1;

        Debug.Log("Player " + (roundManager.GetCurrentPlayerIndex() + 1) + " rolled: " + finalSide);

        // End the current round
        roundManager.EndCurrentRound();
        EmpGameObject =  GameObject.FindWithTag("emp").GetComponent<stickGeneration>();
        EmpGameObject.StartTurn(finalSide);
    }

    // Add a method to access finalSide from other scripts
    public int GetFinalSide()
    {
        return finalSide;
    }
}
