using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaEsferas : MonoBehaviour
{
    float posicionX=0;
    float posicionZ=0;
    GameObject plano ;
    GameObject cubo ;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=  RandomPlano();
    }

    // Update is called once per frame
    void Update()
    {
        cubo = GameObject.Find("Cube");
        Vector3 posicionCubo=cubo.transform.position;
        if (Input.GetKeyDown(KeyCode.D)){
            posicionX++;
            transform.position= new Vector3(posicionX , 0f, posicionZ);            
        }
        if (Input.GetKeyDown(KeyCode.A)){
            posicionX--;
            transform.position= new Vector3(posicionX, 0f, posicionZ);
        }
        if (Input.GetKeyDown(KeyCode.W)){
            posicionZ++;
            transform.position= new Vector3(posicionX, 0f, posicionZ);
        }
        if (Input.GetKeyDown(KeyCode.S)){
            posicionZ--;
            transform.position= new Vector3(posicionX, 0f, posicionZ);
        }
        if (Input.GetKeyDown(KeyCode.R)){
           transform.position=  RandomPlano();
        }
        if (Vector3.Distance(posicionCubo,transform.position)<1){
           transform.position=  RandomPlano();
        }
    }
    Vector3 RandomPlano(){
        plano = GameObject.Find("Plane"); 
        float width = plano.GetComponent<Renderer>().bounds.size.x;
        float height = plano.GetComponent<Renderer>().bounds.size.z;
        // Generar una posición aleatoria dentro de los límites del objeto Plane
        float randomX = Random.Range(-width / 2f, width / 2f);
        float randomZ = Random.Range(-height / 2f, height / 2f);
        Vector3 randomPosition = new Vector3(randomX, 0f, randomZ);
        return randomPosition ;
    }
}
