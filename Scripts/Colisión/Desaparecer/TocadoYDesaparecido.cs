using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocadoYDesaparecido : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.CompareTag("Sphere")) {
        Destroy(gameObject);
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
