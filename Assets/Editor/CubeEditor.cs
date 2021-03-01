using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        SerializedProperty cubeStatsSP = serializedObject.FindProperty("cube");
        if (cubeStatsSP.objectReferenceValue == null)
        {
            EditorGUILayout.PropertyField(cubeStatsSP);
        }
        else
        {
            CubeStats cube = cubeStatsSP.objectReferenceValue as CubeStats;

            EditorGUILayout.LabelField(cube.displayName + " Stats");
            EditorGUILayout.PropertyField(cubeStatsSP);
            EditorGUILayout.Space();
            cube.strength = EditorGUILayout.IntField("Strength: ", cube.strength);
            cube.body = EditorGUILayout.IntField("Body: ", cube.body);
            cube.will = EditorGUILayout.IntField("Will: ", cube.will);
            EditorGUILayout.Space();
            int health = ((cube.strength + cube.body + cube.will) / 3) * 4;
            int damageTaken = cube.strength % 2;
            int damageDone = cube.strength * 4;
            EditorGUILayout.LabelField("Calculated Stats: ");
            EditorGUILayout.LabelField("Health: " + health);
            EditorGUILayout.LabelField("Damage Taken: " + damageTaken);
            EditorGUILayout.LabelField("Damage Done: " + damageDone);
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Stat: ");
            SerializedProperty stat = serializedObject.FindProperty("stat");
            stat.stringValue = EditorGUILayout.TextField("Stat ", stat.stringValue);
        }
        serializedObject.ApplyModifiedProperties();
    }
}
