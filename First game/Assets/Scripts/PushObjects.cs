using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObjects : MonoBehaviour
{
    private float pushForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rb = hit.collider.attachedRigidbody;

        
        if (rb != null && !rb.isKinematic)
        {
            Vector3 pushDirection = hit.moveDirection; 
            rb.velocity = pushDirection * pushForce; 
        }
    }
}
