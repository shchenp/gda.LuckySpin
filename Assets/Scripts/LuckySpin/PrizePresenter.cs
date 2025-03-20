using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LuckySpin
{
    public class PrizePresenter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _count;
        [SerializeField] private Animator _animator;
        private static readonly int Play = Animator.StringToHash("play");

        public void Show(PrizeData prizeData)
        {
            _name.text = prizeData.Name;
            _image.sprite = prizeData.Sprite;
            _count.text = prizeData.Count;
            
            _animator.SetTrigger(Play);
        }
    }
}