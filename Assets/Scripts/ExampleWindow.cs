using UnityEditor;
using UnityEngine;

public class ExampleWindow : EditorWindow
{

    public string myString = "Text here";
    Color colour;
    [MenuItem("Window/Example")]
    public static void ShowWindow()
    {
        GetWindow<ExampleWindow>("Example");
    }

    private void OnGUI()
    {
        // Window Code
        GUILayout.Label("My Label.", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Text", myString);
        if(GUILayout.Button("Test button"))
        {
            Debug.Log("Working");
        }
        colour = EditorGUILayout.ColorField("Colour", colour);

    }

}
