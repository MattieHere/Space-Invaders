using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreemShake : MonoBehaviour
{
    public float shake;

    // Start is called before the first frame update
    void Start()
    {
        shake = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Random.Range(-shake, shake), Random.Range(-shake, shake), -10);

        if (shake > 0) shake -= 0.1f;

        shake = Mathf.Clamp(shake, 0, 100);

 
    }
}
