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
        public string Count { get; private set; }
    }
}