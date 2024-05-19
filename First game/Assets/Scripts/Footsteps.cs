using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource footstepsSound, jumpSound;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.Space)){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                footstepsSound.enabled = false;
                if(!jumpSound.isPlaying)
                {
                    
                    jumpSound.enabled = true;
                }
                
            }
            else
            {
                footstepsSound.enabled = true;
                jumpSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            jumpSound.enabled = false;
        }
    }
}
