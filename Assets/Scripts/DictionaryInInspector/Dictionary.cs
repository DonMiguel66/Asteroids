using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids 
{ 
    [CreateAssetMenu(fileName = "New Dictionary Data", menuName = "Dictionaries/Dictionary Data Object")]
    public class Dictionary : ScriptableObject
    {
        [SerializeField]
        private List<string> keys = new List<string>();
        [SerializeField]
        private List<int> values = new List<int>();

        public List<string> Keys { get => keys; set => keys = value; }
        public List<int> Values { get => values; set => values = value; }
    }
}