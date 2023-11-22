using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FireArea : MonoBehaviour
{
    public float Velocidade = 2.0f;
    public GameObject FireArea1;
    public GameObject FireArea2;
    public GameObject FireArea3;
    public GameObject FireArea4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (FireArea1.transform.position.z >= 50)
        {
            FireArea1.transform.Translate(Vector3.back * Velocidade * Time.deltaTime);
        }
        if (FireArea2.transform.position.x <= -50)
        {
            FireArea2.transform.Translate(Vector3.right * Velocidade * Time.deltaTime);
        }
        if (FireArea3.transform.position.z <= 50)
        {
            FireArea3.transform.Translate(Vector3.forward * Velocidade * Time.deltaTime);
        }
        if (FireArea4.transform.position.x >= 50)
        {
            FireArea4.transform.Translate(Vector3.left * Velocidade * Time.deltaTime);
        }
    }
}
