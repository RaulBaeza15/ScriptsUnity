using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    int numeroObjeto=0;
    int totalObjetos=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)){
            GameObject cam = GameObject.Find("Main Camera");
            GameObject cubo = GameObject.Find("Cube");
            GameObject cubo2 = GameObject.Find("Cube (1)");
            if(numeroObjeto%totalObjetos==0){
                cam.transform.LookAt(cubo.transform);
            }else{
               cam.transform.LookAt(cubo2.transform); 
            }
            

            

            numeroObjeto++;
        }
    }
}
