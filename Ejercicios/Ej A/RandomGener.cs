using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGener : MonoBehaviour
{
    float posicionX=0;
    float posicionZ=0;
    GameObject plano ;
    private Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        plano = GameObject.Find("Plane");
        Color color = new Color(1f, 0f, 0f); // Rojo
        
        GetComponent<Renderer>().material.color = color;
        float width = plano.GetComponent<Renderer>().bounds.size.x;
        float height = plano.GetComponent<Renderer>().bounds.size.z;

        // Generar una posición aleatoria dentro de los límites del objeto Plane
        float randomX = Random.Range(-width / 2f, width / 2f);
        float randomZ = Random.Range(-height / 2f, height / 2f);
        Vector3 randomPosition = new Vector3(randomX, 0f, randomZ);
        transform.position=  randomPosition;
        

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
        if (Input.GetKeyDown(KeyCode.R)){
           plano = GameObject.Find("Plane"); 
           float width = plano.GetComponent<Renderer>().bounds.size.x;
        float height = plano.GetComponent<Renderer>().bounds.size.z;

        // Generar una posición aleatoria dentro de los límites del objeto Plane
        float randomX = Random.Range(-width / 2f, width / 2f);
        float randomZ = Random.Range(-height / 2f, height / 2f);
        Vector3 randomPosition = new Vector3(randomX, 0f, randomZ);
        transform.position=  randomPosition;
        }
    }
    
}
