using UnityEngine;

namespace Asteroids
{
    public class InfoWindow : MonoBehaviour, IUI
    {
        public void Execute()
        {
            gameObject.SetActive(true);
        }

        public void Cancel()
        {
            gameObject.SetActive(false);
        }
    }
}