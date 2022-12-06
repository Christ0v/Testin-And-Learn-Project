using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfCustards { get; private set; }

   public UnityEvent<PlayerInventory> OnCustardsCollected;   

   public void CustardsCollected()
    {
        NumberOfCustards++;
        OnCustardsCollected.Invoke(this);
    }
}
