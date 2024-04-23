using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Extensions
{
    public class HeroSelectionScreen : Screen
    {
        [SerializeField] private TextMeshProUGUI _playerName;
        [SerializeField] private TextMeshProUGUI _heroName;

        [SerializeField] private TextMeshProUGUI _level;
        [SerializeField] private ExperienceSlider _experience;
        [SerializeField] private Image _class;

        [SerializeField] private Button _buyButton;
        [SerializeField] private TextMeshProUGUI _heroCost;
        [SerializeField] private Button _selectHero;

        [SerializeField] private Slider _health;
        [SerializeField] private Slider _attack;
        [SerializeField] private Slider _defence;
        [SerializeField] private Slider _speed;

        public void SetStats(HeroStats heroStats)
        {
            _playerName.text = heroStats.PlayerName;
            _heroName.text = heroStats.HeroName;

            _level.text = heroStats.Level.ToString();
            _experience.SetValue(heroStats.Experience);
            _class.sprite = heroStats.Class;

            _heroCost.text = heroStats.Cost.ToString();
            CheckButtons(heroStats.IsAvailable);

            _health.value = heroStats.Health;
            _attack.value = heroStats.Attack;
            _defence.value = heroStats.Defence;
            _speed.value = heroStats.Speed;
        }

        private void CheckButtons(Boolean isAvailable)
        {
            if (isAvailable)
            {
                _buyButton.gameObject.SetActive(false);
                _selectHero.interactable = true;
            }
            else
            {
                _buyButton.gameObject.SetActive(true);
                _selectHero.interactable = false;
            }
        }
    }
}