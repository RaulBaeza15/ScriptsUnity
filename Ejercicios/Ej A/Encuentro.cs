using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encuentro : MonoBehaviour
{
    GameObject cam ;
    GameObject cubo ;
    // Start is called before the first frame update
    void Start()
    {
          cam = GameObject.Find("Main Camera");
         cubo = GameObject.Find("Cube");
        cam.transform.LookAt(cubo.transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        cubo.transform.Rotate(new Vector3(0f,10f,0f));
    }
}
