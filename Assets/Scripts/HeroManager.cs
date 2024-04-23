using System;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    public event Func<int> GetPlayerMoney;
    public event Action<int> PurchaseHero;
    
    public event Action<HeroStats> SetHeroStats;
    public event Action<HeroStats> ChooseHero;
    
    [SerializeField] private List<HeroStats> _heroes;

    [SerializeField]
    private int _currentIndex;

    private int _previousIndex;
    private HeroStats _chosenHero;

    private void Start()
    {
        _chosenHero = _heroes[_currentIndex];
        ChooseHero?.Invoke(_chosenHero);
        ShowHero();
    }

    public void ShowPrevious()
    {
        _previousIndex = _currentIndex;
        _currentIndex = (_currentIndex - 1 + _heroes.Count) % _heroes.Count;

        ShowHero();
    }

    public void ShowNext()
    {
        _previousIndex = _currentIndex;
        _currentIndex = (_currentIndex + 1) % _heroes.Count;
        
        ShowHero();
    }

    private void ShowHero()
    {
        var previousHero = _heroes[_previousIndex];
        previousHero.gameObject.SetActive(false);
        
        var hero = _heroes[_currentIndex];
        hero.gameObject.SetActive(true);
        SetHeroStats?.Invoke(hero);
    }

    public void ShowChosenHero()
    {
        _heroes[_currentIndex].gameObject.SetActive(false);
        _currentIndex = _heroes.IndexOf(_chosenHero);
        
        ShowHero();
    }

    public void SetHero()
    {
        _chosenHero = _heroes[_currentIndex];
        ChooseHero?.Invoke(_chosenHero);
    }

    public void TryPurchase()
    {
        var playerMoney = GetPlayerMoney?.Invoke();
        var hero = _heroes[_currentIndex];

        if (playerMoney >= hero.Cost)
        {
            PurchaseHero?.Invoke(hero.Cost);
            hero.SetAvailable();
            ShowHero();
        }
    }
}
