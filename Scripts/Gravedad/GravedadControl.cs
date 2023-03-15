using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravedadControl : MonoBehaviour
{
    public float gravedad = -9.81f;
    float gravedadLuna = -1.62f;

    
    // Start is called before the first frame update
    void Start()
    {
        gravedad = gravedadLuna;
        Physics.gravity = new Vector3(0f, gravedad, 0f);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.P)){
        gravedad++;
        Physics.gravity = new Vector3(0f, gravedad, 0f);
       }
       if (Input.GetKeyDown(KeyCode.L)){
        gravedad--;
        Physics.gravity = new Vector3(0f, gravedad, 0f);
       }
    }
}
