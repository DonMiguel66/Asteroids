using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace Asteroids 
{ 
    [CustomEditor(typeof(DictionaryInInspector))]
    public class DictionaryCustomEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            {
                if (((DictionaryInInspector)target).modifyValues)
                {
                    if (GUILayout.Button("Save Changes"))
                    {
                        ((DictionaryInInspector)target).DeserializationDictionary();
                    }
                }
            }
        }
    }
}