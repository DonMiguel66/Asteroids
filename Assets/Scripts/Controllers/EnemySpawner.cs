using System.Collections;
using UnityEngine;

namespace Asteroids
{
    public class EnemySpawner : MonoBehaviour
    {
        private GameObject _enemy;
        private GameObject target;
        public float radius = 250.0f;
        public float spawnRate = 5.0f;
        public float variance = 1.0f;
        public bool spawnEnemy = false;

        public IEnumerator CreateEnemies()
        {
            IEnemyFactory ufosFactory = new UFOsFactory();
            target = GameObject.Find("Base");
            _enemy = ufosFactory.Create(new Health(100.0f, 100.0f), target).gameObject;

            while (true)
            {
                float nextSpawnTime
                = spawnRate + Random.Range(-variance, variance);
                yield return new WaitForSeconds(nextSpawnTime);
                yield return new WaitForFixedUpdate();
                CreateNewEnemy();
            }
        }
        void CreateNewEnemy()
        {
            if (spawnEnemy == false)
            {
                return;
            }
            var enemyPosition = Random.onUnitSphere * radius;
            enemyPosition.Scale(transform.lossyScale);
            enemyPosition += transform.position;
            var newEnemy = Instantiate(_enemy);
            newEnemy.transform.position = enemyPosition;
            newEnemy.transform.LookAt(target.transform);
        }

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawWireSphere(Vector3.zero, radius);
        }
        public void DestroyAllEnemies()
        {
            foreach (var enemy in FindObjectsOfType<Enemy>())
            {
                Destroy(enemy.gameObject);
            }
        }
    }

}
