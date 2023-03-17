using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class colorcubo : MonoBehaviour
{
    private int colorIndex = 0;
    private Color[] colors = { Color.red, Color.blue, Color.green, Color.yellow };
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", colors[colorIndex]);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            renderer.material.SetColor("_Color", colors[colorIndex]);
        }
    }
}
