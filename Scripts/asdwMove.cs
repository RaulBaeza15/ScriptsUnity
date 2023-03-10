using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdwMove : MonoBehaviour
{
    public float velocidad = 5f; // velocidad de movimiento del cubo
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular la dirección del movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);

        // Aplicar el movimiento al objeto del juego (cubo)
        transform.position += movimiento * velocidad * Time.deltaTime; 
    }
}
