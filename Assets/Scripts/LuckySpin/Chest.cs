using System;
using System.Collections.Generic;
using Extensions;
using UnityEngine;

namespace LuckySpin
{
    public class Chest : MonoBehaviour
    {
        public Dictionary<string, int> Prizes { get; } = new();

        private void Awake()
        {
            Prizes.Add(GlobalConstants.COIN_TAG, 0);
            Prizes.Add(GlobalConstants.GEM_TAG, 0);
            Prizes.Add(GlobalConstants.LIFE_TAG, 0);
            Prizes.Add(GlobalConstants.RUNE_TAG, 0);
        }

        public void AddPrize(PrizeData prizeData)
        {
            switch (prizeData.tag)
            {
                case GlobalConstants.SKULL_TAG:
                    return;
                
                case GlobalConstants.RUNE_TAG:
                    Prizes[prizeData.tag]++;
                    return;
                
                default:
                    Prizes[prizeData.tag] += Convert.ToInt32(prizeData.Count);
                    return;
            }
        }

        public Dictionary<string, int> GetPrizes()
        {
            return Prizes;
        }
    }
}