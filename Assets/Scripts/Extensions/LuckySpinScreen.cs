using LuckySpin;
using TMPro;
using UnityEngine;

namespace Extensions
{
    public class LuckySpinScreen : Screen
    {
        [SerializeField] private Token _token;
        [SerializeField] private TextMeshProUGUI _tokenCount;

        private void Awake()
        {
            _token.CountChanged += OnCountChanged;
        }

        private void OnDestroy()
        {
            _token.CountChanged -= OnCountChanged;
        }

        private void OnCountChanged(int tokenCount)
        {
            _tokenCount.text = tokenCount.ToString();
        }

        public void SetStats(HeroStats heroStats)
        {
            
        }
    }
}