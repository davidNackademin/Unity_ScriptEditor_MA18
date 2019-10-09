using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SquareManager))]
public class SqManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SquareManager squareManager = (SquareManager) target;

       if( GUILayout.Button("New Square"))
        {
            squareManager.NewSquare();
            
        }

    }

}
