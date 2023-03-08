using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class colorcubo : MonoBehaviour
{
    int numeroColor=0;
    // Start is called before the first frame update
    void Start()
    {
        
        
        Color color = new Color32(0, 255, 128, 255);; // blanco
        GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        Color[] colors = new Color[] { Color.red, Color.blue, Color.green, Color.yellow };


        
        if (Input.GetKeyDown(KeyCode.C)){
            GetComponent<Renderer>().material.color = colors[numeroColor%colors.Length];
            numeroColor++;
        }








        
        
    }
}
