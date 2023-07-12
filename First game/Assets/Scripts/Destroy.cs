using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
  bool Next = false;
  bool Key = false;
  void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Player"))
    {
    Key = true;
    } 

    
  } 
   void OnTriggerExit(Collider other)
  {
    if(other.CompareTag("Player"))
    {
    Key = false;
    } 

  }     
  void Update()
  {
    if(Input.GetKey(KeyCode.E) && Key)
    gameObject.SetActive(false);
  }

}
