using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ClickSquareController))]
public class SquareScriptEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ClickSquareController clickSquare = (ClickSquareController) target;

        EditorGUILayout.LabelField("Level", clickSquare.Level.ToString());

    }


}
