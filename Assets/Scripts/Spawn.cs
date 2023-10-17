using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] a;
    [SerializeField] GameObject s;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Dothis", 4, 10f);
    }

    void Dothis()
    {
        Instantiate(a[0], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
