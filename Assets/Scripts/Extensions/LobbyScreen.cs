using System;
using TMPro;
using UnityEngine;

namespace Extensions
{
    public class LobbyScreen : Screen
    {
        [SerializeField] private TextMeshProUGUI _playerName;
        [SerializeField] private TextMeshProUGUI _level;
        [SerializeField] private ExperienceSlider _experience;

        public void SetStats(HeroStats heroStats)
        {
            _playerName.text = heroStats.PlayerName;
            _level.text = heroStats.Level.ToString();
            _experience.SetValue(heroStats.Experience);
        }
    }
}