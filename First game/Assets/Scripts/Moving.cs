using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float force = 5.0f;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(Vector3.right * force);
        rigidbody.AddForce(Vector3.left * force);
        rigidbody.AddForce(Vector3.forward * force);
        rigidbody.AddForce(Vector3.back * force);
    }
}
