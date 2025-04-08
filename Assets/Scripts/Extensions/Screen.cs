using TMPro;
using UnityEngine;

namespace Extensions
{
    public class Screen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coins;
        [SerializeField] private TextMeshProUGUI _diamonds;
        [SerializeField] private NumberAnimator _coinsAnimator;
        [SerializeField] private NumberAnimator _diamondsAnimator;

        public void SetCoins(int coins)
        {
            _coins.text = coins.ToString();
        }

        public void SetCoinsAdditive(int additive)
        {
            _coinsAnimator.AnimateNumber(additive);
        }

        public void SetDiamonds(int diamonds)
        {
            _diamonds.text = diamonds.ToString();
        }

        public void SetDiamondsAdditive(int additive)
        {
            _diamondsAnimator.AnimateNumber(additive);
        }
    }
}