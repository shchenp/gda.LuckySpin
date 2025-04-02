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
            if (prizeData.CompareTag(GlobalConstants.SKULL_TAG))
            {
                return;
            }

            Prizes[prizeData.tag] += prizeData.Count;
        }
    }
}