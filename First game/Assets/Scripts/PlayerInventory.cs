using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfCustards { get; private set; }

   public UnityEvent<PlayerInventory> OnCustardsCollected;   

   public void CustardsCollected()
    {
        NumberOfCustards++;
        OnCustardsCollected.Invoke(this);
     if(NumberOfCustards == 10)
        {   
            //SceneManager.LoadScreen("End Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
}
