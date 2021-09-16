using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class ViewServices
    {
        private readonly Dictionary<string, ObjectPool> _viewCache = new Dictionary<string, ObjectPool>(15);

        public GameObject Instantiate(GameObject prefab)
        {
            GameObject gameObject;
            if(!_viewCache.TryGetValue(prefab.name, out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                _viewCache[prefab.name] = viewPool;
            }

            gameObject = viewPool.Pop();
            return gameObject;
        }

        public void Destroy(GameObject value)
        {
            _viewCache[value.name].Push(value);
        }
    }
}
