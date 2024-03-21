using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoFloor3 : MonoBehaviour
{
   public GameObject greenButton;
    public GameObject anyDoors;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (greenButton.activeSelf) // Sprawdzamy, czy zielony przycisk jest aktywny
            {
                TeleportPlayer(); // Jeśli tak, teleportujemy gracza
            }
        }
    }

    void TeleportPlayer()
    {
        Debug.Log("Teleporting player to another level...");
        SceneManager.LoadScene("Floor3"); // Przykładowe użycie SceneManager.LoadScene
    }
}
