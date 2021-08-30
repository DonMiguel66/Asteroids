using System.Collections;
using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private GameObject _emenySpawner;
        private void Start()
        {   
            //Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));

            //IEnemyFactory ufosFactory = new UFOsFactory();
            //ufosFactory.Create(new Health(100.0f, 100.0f));

            //IEnemyFactory asteroidsFactory = new AsteroidsFactory();
            //asteroidsFactory.Create(new Health(100.0f, 100.0f));

            //Enemy.Factory = asteroidsFactory;
            //Enemy.Factory.Create(new Health(100.0f, 100.0f));

            _emenySpawner = GameObject.Find("EnemySpawner");
            var enemySpawnerScript  = _emenySpawner.GetComponent<EnemySpawner>();
            StartCoroutine(enemySpawnerScript.CreateEnemies());
        }

        
    }
}
