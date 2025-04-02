using UnityEngine;

namespace LuckySpin
{
    public class LuckySpinManager : MonoBehaviour
    {
        [SerializeField] private Roulette _roulette;
        [SerializeField] private PrizePresenter _prizePresenter;
        [SerializeField] private Chest _chest;

        private void Awake()
        {
            _roulette.OnGetPrize += _prizePresenter.Show;
            _roulette.OnGetPrize += _chest.AddPrize;
        }

        private void OnDestroy()
        {
            _roulette.OnGetPrize -= _prizePresenter.Show;
            _roulette.OnGetPrize -= _chest.AddPrize;
        }
    }
}