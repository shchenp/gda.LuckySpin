using Extensions;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace LuckySpin
{
    public class PrizePresenter : MonoBehaviour
    {
        public UnityEvent AnimationStart;
        public UnityEvent MoveToChestAlmostDoneEvent;
        public UnityEvent MoveToChestDoneEvent;
        
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _count;
        [SerializeField] private Animator _animator;
        private static readonly int Play = Animator.StringToHash("play");
        private static readonly int Skull = Animator.StringToHash("skull");

        public void Show(PrizeData prizeData)
        {
            _name.text = prizeData.Name;
            _image.sprite = prizeData.Sprite;
            _count.text = prizeData.Count.ToString();

            if (prizeData.CompareTag(GlobalConstants.SKULL_TAG))
            {
                _animator.SetTrigger(Skull);
                return;
            }
            
            _animator.SetTrigger(Play);
        }

        [UsedImplicitly]
        public void OnAnimationStart()
        {
            AnimationStart?.Invoke();
        }

        [UsedImplicitly]
        public void OnMoveToChestAlmostDone()
        {
            MoveToChestAlmostDoneEvent?.Invoke();
        }

        [UsedImplicitly]
        public void OnMoveToChestDone()
        {
            MoveToChestDoneEvent?.Invoke();
        }
    }
}