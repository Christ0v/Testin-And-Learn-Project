using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.CustardsCollected();
            gameObject.SetActive(false);
        }
    }
}
