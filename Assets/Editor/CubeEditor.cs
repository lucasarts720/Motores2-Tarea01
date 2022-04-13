using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MoverCubo))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        MoverCubo cube = (MoverCubo)target;

        if (GUILayout.Button("Mover Cubo"))
        {
            cube.move();
        }

        if (GUILayout.Button("Reset"))
        {
            cube.reset();
        }
    }
}
