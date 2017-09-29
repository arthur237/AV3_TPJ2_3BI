using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(PotionSelectorAttribute))]

public class PotionD : PropertyDrawer {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        int index = 0;
        string[] d = new string[PotionDB.Instance.potions.Length];
        for (int i = 0;  i < PotionDB.Instance.potions.Length; i++)
        {
            d[i] = PotionDB.Instance.potions[i].name;
            if (d[i] == property.stringValue)
            {
                index = i;
            }






        }
        index = EditorGUI.Popup(position, index, d);
        property.stringValue = d[index];

    }

}
