using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public event Action<int> OnCoinsChanged;
    public event Action<int> OnDiamondsChanged;
    
    [SerializeField] 
    private int _coins;
    [SerializeField]
    private int _diamonds;

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
}
