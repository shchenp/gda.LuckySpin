using JetBrains.Annotations;
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
    }
}