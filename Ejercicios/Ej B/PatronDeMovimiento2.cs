using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronDeMovimiento2 : MonoBehaviour
{
    GameObject esfera1;
    GameObject esfera2;
    GameObject esfera3;
    GameObject esferaActual;
    int numEsfera=0;

    float velocidad =1;
    // Start is called before the first frame update
    void Start()
    {
        velocidad= 1;
        esfera1 = GameObject.Find("Sphere");
        esfera2 = GameObject.Find("Sphere (1)");
        esfera3 = GameObject.Find("Sphere (2)");
        esferaActual=esfera1;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 posicionEsfera=esferaActual.transform.position;
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
        if (Vector3.Distance(posicionEsfera,transform.position)<1.3){
            if(numEsfera%3==0){
                esferaActual=esfera1;
            }if(numEsfera%3==1){
                esferaActual=esfera2;
            }if(numEsfera%3==2){
                esferaActual=esfera3;
            }
           numEsfera++;
        }
    }
}
