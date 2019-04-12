using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorTest : PropertyDrawer
{

    // objectField for objects, propertyFields for properties
    public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
    {
        try
        {
            int pos = int.Parse(property.propertyPath.Split('[',']')[1]);
            EditorGUI.PropertyField(rect, property, new GUIContent(((ArrayTest) attribute).Testing[pos]));
        }
        catch
        {
            EditorGUI.PropertyField(rect, property, label);
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
