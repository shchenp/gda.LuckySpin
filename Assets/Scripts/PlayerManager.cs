using System;
using Extensions;
using LuckySpin;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public event Action<int> OnCoinsChanged;
    public event Action<int> OnCoinsAdd; 
    public event Action<int> OnDiamondsChanged;
    public event Action<int> OnDiamondsAdd; 
    
    [SerializeField] 
    private int _coins;
    [SerializeField]
    private int _diamonds;
    [SerializeField] 
    private Chest _chest;

    private HeroStats _currentHero;

    private void Start()
    {
        OnCoinsChanged?.Invoke(_coins);
        OnDiamondsChanged?.Invoke(_diamonds);
    }

    public void SetHero(HeroStats hero)
    {
        _currentHero = hero;
    }

    public int GetMoney()
    {
        return _coins;
    }

    public void BuyHero(int cost)
    {
        _coins -= cost;
        OnCoinsChanged?.Invoke(_coins);
    }

    public void AddPrizes()
    {
        var coins = _chest.Prizes[GlobalConstants.COIN_TAG];
        var gems = _chest.Prizes[GlobalConstants.GEM_TAG];
        
        OnCoinsAdd?.Invoke(coins);
        OnDiamondsAdd?.Invoke(gems);
    }
}
