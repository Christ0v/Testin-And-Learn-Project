using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI custardText; 
    
    void Start()
    {
        custardText = GetComponent<TextMeshProUGUI>();

    }
    public void UpdateCustardText(PlayerInventory playerInventory)
   {
       custardText.text = playerInventory.NumberOfCustards.ToString();
    }
};
