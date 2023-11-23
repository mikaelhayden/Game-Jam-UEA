using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DetectaAnimal : MonoBehaviour
{

    private TextMeshProUGUI pontos;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        pontos = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Animal")
        {
            count += 1;
            collider.gameObject.SetActive(false);
            pontos.text = count.ToString();
        }

        Console.WriteLine("OnTriggerEnter");
    }
}
