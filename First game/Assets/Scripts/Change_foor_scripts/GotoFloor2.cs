using UnityEngine.SceneManagement;
using UnityEngine;

public class GotoFloor2 : MonoBehaviour
{

  void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Player"))
    SceneManager.LoadScene("Floor2");
  }   
     
}

