using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        RawImage c1 = GetComponentInChildren<RawImage>();
        RawImage c2 = GetComponentInChildren<RawImage>();
        RawImage c3 = GetComponentInChildren<RawImage>();
        Debug.Log(c1.enabled = false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
