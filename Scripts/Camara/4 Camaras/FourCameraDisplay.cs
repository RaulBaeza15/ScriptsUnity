using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourCameraDisplay : MonoBehaviour
{
    public Camera[] cameras; // Array de las cuatro cámaras que quieres mostrar
    public int padding = 10; // Espacio entre los cuadros de cámara y los bordes de la pantalla

    private Rect[] cameraRects; // Array de las posiciones y tamaños de cada cámara en pantalla
    private Texture2D[] cameraTextures; // Array de las texturas de cada cámara

    private void Start()
    {
        // Inicializar los arrays de posiciones y texturas
        cameraRects = new Rect[cameras.Length];
        cameraTextures = new Texture2D[cameras.Length];

        // Calcular las posiciones y tamaños de cada cámara en pantalla
        float screenWidth = Screen.width / 2f - padding * 1.5f;
        float screenHeight = Screen.height / 2f - padding * 1.5f;
        for (int i = 0; i < cameras.Length; i++)
        {
            float x = (i % 2) * (screenWidth + padding) + padding;
            float y = (i / 2) * (screenHeight + padding) + padding;
            cameraRects[i] = new Rect(x, y, screenWidth, screenHeight);
            cameraTextures[i] = new Texture2D((int)screenWidth, (int)screenHeight);
        }
    }

    private void OnGUI()
    {
        // Para cada cámara, renderizar su vista en una textura y mostrarla en un cuadro en pantalla
        for (int i = 0; i < cameras.Length; i++)
        {
            Camera camera = cameras[i];
            Rect cameraRect = cameraRects[i];
            Texture2D cameraTexture = cameraTextures[i];

            // Renderizar la vista de la cámara en la textura correspondiente
            RenderTexture renderTexture = new RenderTexture(cameraTexture.width, cameraTexture.height, 24);
            camera.targetTexture = renderTexture;
            camera.Render();
            RenderTexture.active = renderTexture;
            cameraTexture.ReadPixels(new Rect(0, 0, cameraTexture.width, cameraTexture.height), 0, 0);
            cameraTexture.Apply();
            camera.targetTexture = null;
            RenderTexture.active = null;

            // Mostrar la textura de la cámara en un cuadro en pantalla
            GUI.DrawTexture(cameraRect, cameraTexture, ScaleMode.StretchToFill, false);
        }
    }
}
