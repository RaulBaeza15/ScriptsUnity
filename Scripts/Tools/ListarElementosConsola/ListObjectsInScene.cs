using UnityEngine;
using UnityEditor;

public class ListObjectsInScene : EditorWindow
{
    [MenuItem("Tools/List Objects in Scene")]
    public static void ShowWindow()
    {
        // Create window
        EditorWindow window = EditorWindow.GetWindow(typeof(ListObjectsInScene));
        window.titleContent = new GUIContent("List Objects in Scene");

        // Get all game objects in the scene
        GameObject[] allObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
        string elementos = "";

        // Display each object's name in the console
        foreach (GameObject obj in allObjects)
        {
            elementos = elementos +"{ "+obj.name+" } ";
        }
        Debug.Log(elementos);
    }
}
