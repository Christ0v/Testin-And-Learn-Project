using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource footstepsSound, sprintSound;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.Space)){
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                //sprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true;
                //sprintSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            //sprintSound.enabled = false;
        }
    }
}
