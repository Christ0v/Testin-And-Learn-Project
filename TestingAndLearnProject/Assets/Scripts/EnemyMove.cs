using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public Vector3 destination;
    public Transform Player, patrol;
    public NavMeshAgent agent;
   // public GameObject cube;
    public bool spotted;
    public float searchTime;

    void Update()
    {
        if (spotted == false)
        {
           // cube.SetActive(false);
            destination = patrol.position;
            agent.destination = destination;
        }
        if (spotted == true)
        {
          //  cube.SetActive(true);
            destination = Player.position;
            agent.destination = destination;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spotted = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(search());
        }
    }
    IEnumerator search()
    {
        yield return new WaitForSeconds(searchTime);
        spotted = false;
    }
}
