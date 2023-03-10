using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGener : MonoBehaviour
{
    float posicionX=0;
    float posicionZ=0;

    // Start is called before the first frame update
    void Start()
    {
        Color color = new Color(1f, 0f, 0f); // blanco
        
        GetComponent<Renderer>().material.color = color;
        transform.position= new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)){
            posicionX++;
            transform.position= new Vector3(posicionX, 0f, 0f);            
        }
        if (Input.GetKeyDown(KeyCode.A)){
            posicionX--;
            transform.position= new Vector3(posicionX, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.W)){
            posicionZ++;
            transform.position= new Vector3(0f,0f ,posicionZ );
        }
        if (Input.GetKeyDown(KeyCode.S)){
            posicionZ--;
            transform.position= new Vector3(0f,0f ,posicionZ );
        }
    }
}
