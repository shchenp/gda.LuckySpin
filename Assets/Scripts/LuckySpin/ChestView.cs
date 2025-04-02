using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

namespace LuckySpin
{
    public class ChestView : MonoBehaviour
    {
        public UnityEvent AnimationStart;
        
        [SerializeField] 
        private Animator _animator;

        private static readonly int IsTokensOut = Animator.StringToHash("isTokensOut");

        public void OnTokensOut()
        {
            _animator.SetBool(IsTokensOut, true);
        }

        [UsedImplicitly]
        private void OnAnimationStart()
        {
            AnimationStart?.Invoke();
        }
    }
}