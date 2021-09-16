using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids 
{
    public class Reference 
    {
        private GameObject _shell;
        private GameObject _rocket;
        public GameObject Shell
        {
            get
            {
                if (_shell == null)
                {
                    _shell = Resources.Load<GameObject>("Prefabs/Shell");
                }

                return _shell;
            }
        }
        public GameObject Rocket
        {
            get
            {
                if (_rocket == null)
                {
                    _rocket = Resources.Load<GameObject>("Prefabs/Rocket");
                }

                return _rocket;
            }
        }
    }
}
