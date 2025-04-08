using Extensions;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace LuckySpin
{
    public class ChestView : MonoBehaviour, IPointerClickHandler
    {
        public UnityEvent AnimationStart;
        
        [SerializeField] 
        private Animator _animator;

        [SerializeField] private Chest _chest;
        [SerializeField] private TextMeshProUGUI _cointCount;
        [SerializeField] private TextMeshProUGUI _gemsCount;
        [SerializeField] private TextMeshProUGUI _runeCount;
        [SerializeField] private TextMeshProUGUI _lifeCount;

        private static readonly int IsTokensOut = Animator.StringToHash("isTokensOut");
        private static readonly int Clicked = Animator.StringToHash("clicked");

        public void OnTokensOut()
        {
            _animator.SetBool(IsTokensOut, true);
        }

        [UsedImplicitly]
        private void OnAnimationStart()
        {
            AnimationStart?.Invoke();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            _animator.SetTrigger(Clicked);
        }

        [UsedImplicitly]
        private void SetPrizesCounts()
        {
            _cointCount.text = _chest.Prizes[GlobalConstants.COIN_TAG].ToString();
            _gemsCount.text = _chest.Prizes[GlobalConstants.GEM_TAG].ToString();
            _runeCount.text = _chest.Prizes[GlobalConstants.RUNE_TAG].ToString();
            _lifeCount.text = _chest.Prizes[GlobalConstants.LIFE_TAG].ToString();
        }
    }
}