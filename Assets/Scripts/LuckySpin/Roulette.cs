using System;
using UnityEngine;

namespace LuckySpin
{
    public class Roulette : MonoBehaviour
    {
        public event Action<PrizeData> OnGetPrize;
        
        [SerializeField] private Arrow _arrow;

        public void GetPrize()
        {
            var prize = _arrow.PrizeObject.GetComponent<PrizeData>();
            
            OnGetPrize?.Invoke(prize);
        }
    }
}