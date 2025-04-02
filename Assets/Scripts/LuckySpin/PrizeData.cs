using UnityEngine;

namespace LuckySpin
{
    public class PrizeData : MonoBehaviour
    {
        [field: SerializeField]
        public string Name { get; private set; }
        
        [field: SerializeField]
        public Sprite Sprite { get; private set; }
        
        [field: SerializeField]
        public int Count { get; private set; }
    }
}