using UnityEngine;

public class IncrementScript : MonoBehaviour
{
    public int slot1 = 0;
    public int slot2 = 0;
    public int slot3 = 0;
    public int slot4 = 0;
    public int slot5 = 0;

    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;
    public GameObject gameObject5;

    void Start()
    {
        // Initialize all slots with value 0
        slot1 = 0;
        slot2 = 0;
        slot3 = 0;
        slot4 = 0;
        slot5 = 0;

        // Assign game objects to slots
        AssignGameObjects();
    }

    void AssignGameObjects()
    {
        // Assign game objects to slots
        gameObject1 = GameObject.Find("GameObject1");
        gameObject2 = GameObject.Find("GameObject2");
        gameObject3 = GameObject.Find("GameObject3");
        gameObject4 = GameObject.Find("GameObject4");
        gameObject5 = GameObject.Find("GameObject5");
    }

   // void Update()
   // {
        // Increment slots and update game objects if necessary
   //     IncrementSlot(ref slot1, ref gameObject1);
   //     IncrementSlot(ref slot2, ref gameObject2);
   //     IncrementSlot(ref slot3, ref gameObject3);
   //     IncrementSlot(ref slot4, ref gameObject4);
   //     IncrementSlot(ref slot5, ref gameObject5);
   // }

    void IncrementSlot(ref int slot, ref GameObject gameObject)
    {
        // Increment the slot value
        slot++;

        // Update the game object associated with the slot
        // For simplicity, assuming the game object's name is the same as the slot name
        gameObject = GameObject.Find("Slot" + slot);
    }
}
