using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looping : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRendered;
   

    // Update is called once per frame
    void Update()
    {
        
        backgroundRendered.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
