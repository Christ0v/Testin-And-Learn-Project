using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlasLightMarch : MonoBehaviour
{
    //public bool isOn = false;
    // public GameObject lightSource;
    //  public bool failSafe = false;
    [SerializeField] GameObject FlashlightLight;
    private bool FlashlightActive = false;
    public AudioSource click;

    void Start()
    {
        //FlashlightActive.gameObject.SetActive(false);
    
    }

  
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.F))
        //  {
        //  if (isOn == false && failSafe == false)
        // {
        //
        //     failSafe = true;
        //      lightSource.SetActive(true);
        //    isOn = true;
        //     StartCoroutine(FailSafe());
        ////
        //   }
        //   if (isOn == true && failSafe == false)
        //   {

        //   failSafe = true;
        //   lightSource.SetActive(false);
        //  isOn = false;
        //   StartCoroutine(FailSafe());


        //  }

        //  }

        if (Input.GetKeyDown(KeyCode.F))
        {
            click.Play();
            if (FlashlightActive == false)
            {
                FlashlightLight.gameObject.SetActive(true);
                FlashlightActive = true;


            }
            else {

                FlashlightLight.gameObject.SetActive(false);
                FlashlightActive = false;

            }
        
        
        }
    }
   // IEnumerator FailSafe()
   // {
        //yield return new WaitForSeconds(0.25f);
       // failSafe = false;
  //  }
}
