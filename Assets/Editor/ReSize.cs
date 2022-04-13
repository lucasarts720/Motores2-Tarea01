using UnityEngine;
using UnityEditor;
public class Example : EditorWindow
{
    float aX, aY, aZ;

    [MenuItem("Window/ReSize")]
    public static void ShowWindow()
    {
        GetWindow<Example>("Re-Size");
    }
    void OnGUI()
    {
        GUILayout.Label("Rescale the selected GameObjects");

        GUILayout.BeginHorizontal();

        aX = EditorGUILayout.FloatField(aX);
        aY = EditorGUILayout.FloatField(aY);
        aZ = EditorGUILayout.FloatField(aZ);

        GUILayout.EndHorizontal();
        
        if (GUILayout.Button("Re-size!"))
        {
            foreach (GameObject obj in Selection.gameObjects)
            {
                obj.transform.localScale = new Vector3 (aX,aY,aZ);
            }
        }
    }
}

