using TMPro;
using UnityEngine;

namespace Extensions
{
    public class Screen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coins;
        [SerializeField] private TextMeshProUGUI _diamonds;

        public void SetCoins(int coins)
        {
            _coins.text = coins.ToString();
        }

        public void SetDiamonds(int diamonds)
        {
            _diamonds.text = diamonds.ToString();
        }
    }
}