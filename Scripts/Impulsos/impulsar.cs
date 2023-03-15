using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impulsar : MonoBehaviour
{
    public float fuerza=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space)){
        GetComponent<Rigidbody>().
            AddForce(new Vector3(0f,fuerza,0f),ForceMode.Impulse);

      }  
    }
}
