using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(HexCoordinates))]
public class HexCoordinatesDrawer : PropertyDrawer
{
    public override void OnGUI
    (
        Rect position, SerializedProperty property, GUIContent label
    )
    {
        HexCoordinates coordinates = new HexCoordinates(
            property.FindPropertyRelative("x").intValue,
            property.FindPropertyRelative("z").intValue
        );
        GUI.Label(EditorGUI.PrefixLabel(position, label), coordinates.ToString());
        // toggle cell label back on with the checkbox on the hex cell label prefab to see the coordinates again
    }
}