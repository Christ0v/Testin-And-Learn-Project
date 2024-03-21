using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetButton : MonoBehaviour
{
    public GameObject greenButton;
    public GameObject redButton;
    public GameObject anyDoors;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            greenButton.SetActive(true);
            redButton.SetActive(false);
            anyDoors.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            greenButton.SetActive(false);
            redButton.SetActive(true);
            anyDoors.SetActive(false);
        }
    }
    
}
