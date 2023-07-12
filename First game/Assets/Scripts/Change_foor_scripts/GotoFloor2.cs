using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;



public class GotoFloor2 : MonoBehaviour
{
  bool goNext = false;
  bool isKey = false;
  bool triggered = false;
  public Text displayText;
  
  void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("anyDoors"))
    {
      triggered = true;
      displayText.text = "Find the key";
    }  
  
    if(other.CompareTag("Key"))
      isKey = true;
    
  }
   void OnTriggerExit(Collider other)
  {
    if(other.CompareTag("anyDoors"))
      triggered = false;
  
    if(other.CompareTag("Key"))
      isKey = false;
    
  }      
  void Update()
  {
    if(Input.GetKeyDown(KeyCode.E) && isKey)
    {
    goNext = true;
    displayText.text = "Open trapdoor";
    }

    if(Input.GetKeyDown(KeyCode.E) && triggered && goNext)
    SceneManager.LoadScene("Floor2");
    
  }

  
     
}

