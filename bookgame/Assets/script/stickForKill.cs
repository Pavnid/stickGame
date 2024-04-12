using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers

public class stickForKill : MonoBehaviour
{
    public void kill()
    {
        // Destroy the clicked stick GameObject
        Destroy(gameObject);
    }
}
