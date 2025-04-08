using TMPro;
using UnityEngine;

namespace Extensions
{
    public class Screen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coins;
        [SerializeField] private TextMeshProUGUI _gems;
        [SerializeField] private NumberAnimator _coinsAnimator;
        [SerializeField] private NumberAnimator _gemsAnimator;

        public void SetCoins(int coins)
        {
            _coins.text = coins.ToString();
        }

        public void SetCoinsAdditive(int additive)
        {
            _coinsAnimator.AnimateNumber(additive);
        }

        public void SetGems(int diamonds)
        {
            _gems.text = diamonds.ToString();
        }

        public void SetGemsAdditive(int additive)
        {
            _gemsAnimator.AnimateNumber(additive);
        }
    }
}