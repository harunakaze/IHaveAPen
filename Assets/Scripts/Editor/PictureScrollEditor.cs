using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomPropertyDrawer(typeof(PictureScroll))]
public class PictureScrollEditor : PropertyDrawer {
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        EditorGUI.BeginProperty(position, label, property);

        EditorGUI.PropertyField(position, property.FindPropertyRelative("sprite"), label);

        EditorGUI.EndProperty();
    }
}
