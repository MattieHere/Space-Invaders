using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(spriteRenderer != null)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }
    }
}
