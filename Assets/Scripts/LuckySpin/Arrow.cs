using UnityEngine;

namespace LuckySpin
{
    public class Arrow : MonoBehaviour
    {
        public GameObject PrizeObject { get; private set; }
    
        private void OnTriggerEnter2D(Collider2D other)
        {
            PrizeObject = other.gameObject;
        }
    }
}