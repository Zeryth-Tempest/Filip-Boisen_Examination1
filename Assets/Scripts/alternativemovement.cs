using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alternativemovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(.02f,0,0 * .1f);
        transform.Rotate(0, 0, .2f, Space.Self);
    }
}
