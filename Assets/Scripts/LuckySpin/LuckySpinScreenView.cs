using TMPro;
using UnityEngine;
using Screen = Extensions.Screen;

namespace LuckySpin
{
    public class LuckySpinScreenView : Screen
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
    }
}