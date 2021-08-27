using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids 
{
    public class Reference 
    {
        private GameObject _shot; 
        private GameObject _shootPoint;
        private Player _player;

        public GameObject Shot
        {
            get
            {
                if (_shot == null)
                {
                    var gameObject = Resources.Load<GameObject>("Prefabs/Shot");
                    _shot = Object.Instantiate(gameObject);
                }

                return _shot;
            }
        }
    }
}
