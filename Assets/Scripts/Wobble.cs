using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // should probably make it so the things cant look bad
        transform.localScale = transform.localScale + new Vector3(Random.Range(-.001f,.001f), Random.Range(-.001f,.001f), 0);
    }
}
