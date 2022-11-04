using UnityEngine;

public class Player : MonoBehaviour
{
    public float force = 5.0f;

    bool hasKey;
    Rigidbody rigidbody;
    public GameObject keyImage;         

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector3.right * force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(Vector3.back * force);
        }
    }

    public void CollectKey()
    {
        hasKey = true;
        keyImage.SetActive(true);
    }

}
