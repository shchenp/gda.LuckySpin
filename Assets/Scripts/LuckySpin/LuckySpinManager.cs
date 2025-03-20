using UnityEngine;

namespace LuckySpin
{
    public class LuckySpinManager : MonoBehaviour
    {
        [SerializeField] private Roulette _roulette;
        [SerializeField] private PrizePresenter _prizePresenter;

        private void Awake()
        {
            _roulette.OnGetPrize += _prizePresenter.Show;
        }

        private void OnDestroy()
        {
            _roulette.OnGetPrize -= _prizePresenter.Show;
        }
    }
}