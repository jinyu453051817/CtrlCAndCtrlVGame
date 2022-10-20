using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using
using System.Runtime.CompilerServices;

public class Testtt : MonoBehaviour
{
    private SpriteRenderer sr;
    private bool test;

    public extern bool enabled {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get {
        };
        [MethodImpl(MethodImplOptions.InternalCall)]
        set
        { }
         }

    // Start is called before the first frame update
    void Start()
    {
        enabled = GetComponent<SpriteRenderer>().enabled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
