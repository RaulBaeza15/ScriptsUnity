using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    public int wallWidth = 5;
    public int wallHeight = 5;
    public float cubeWidth = 1f;
    public float cubeHeight = 1f;

    void Start() {
        Vector3 cubeScale = new Vector3(cubeWidth, cubeHeight, cubeWidth);

        for (int x = 0; x < wallWidth; x++) {
            for (int y = 0; y < wallHeight; y++) {
                GameObject cube = Instantiate(cubePrefab);
                cube.transform.position = new Vector3(x * cubeWidth, y * cubeHeight, 0);
                cube.transform.localScale = cubeScale;
                cube.transform.parent = transform;
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
