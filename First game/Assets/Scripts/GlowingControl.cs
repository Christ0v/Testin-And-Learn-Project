using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowingControl : MonoBehaviour
{
    public Material glowingMaterial;
    public Color glowColor = Color.white;
    public float glowIntensity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
       if (glowingMaterial != null)
        {
            glowingMaterial.EnableKeyword("_EMISSION");
            glowingMaterial.SetColor("_EmissionColor", glowColor * glowIntensity);
        } 
    }

    // Update is called once per frame
}
