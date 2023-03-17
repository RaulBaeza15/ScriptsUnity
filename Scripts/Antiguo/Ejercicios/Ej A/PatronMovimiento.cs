using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronMovimiento : MonoBehaviour
{
    GameObject esfera;
    float velocidad =1;
    // Start is called before the first frame update
    void Start()
    {
        velocidad= 1;
        esfera = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {

        
        Vector3 posicionEsfera=esfera.transform.position;
        if (posicionEsfera.z > transform.position.z){
            transform.Translate(Vector3.forward*velocidad*Time.deltaTime);
        }
        if (posicionEsfera.z < transform.position.z){
            transform.Translate(Vector3.back*velocidad*Time.deltaTime);
        }
        if (posicionEsfera.x > transform.position.x){
            transform.Translate(Vector3.right*velocidad*Time.deltaTime);
        }
        if (posicionEsfera.x < transform.position.x){
            transform.Translate(Vector3.left*velocidad*Time.deltaTime);
        }
        
    }
}
