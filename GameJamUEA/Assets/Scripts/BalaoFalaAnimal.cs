using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaoFalaAnimal : MonoBehaviour
{
    private Camera cameraAtiva;
    // Start is called before the first frame update
    void Start()
    {
        cameraAtiva = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = cameraAtiva.transform.up.normalized;
    }
}
