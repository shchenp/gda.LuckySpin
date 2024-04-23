using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] private PlayerManager _playerManager;
   [SerializeField] private ScreenManager _screenManager;
   [SerializeField] private HeroManager _heroManager;

   private void Awake()
   {
       _playerManager.OnCoinsChanged += _screenManager.SetCoins;
       _playerManager.OnDiamondsChanged += _screenManager.SetDiamonds;

       _heroManager.SetHeroStats += _screenManager.HeroSelectionScreen.SetStats;
       
       _heroManager.GetPlayerMoney += _playerManager.GetMoney;
       
       _heroManager.ChooseHero += _playerManager.SetHero;
       _heroManager.ChooseHero += _screenManager.LobbyScreen.SetStats;

       _heroManager.PurchaseHero += _playerManager.BuyHero;
   }

   private void OnDestroy()
   {
       _playerManager.OnCoinsChanged -= _screenManager.SetCoins;
       _playerManager.OnDiamondsChanged -= _screenManager.SetDiamonds;
       
       _heroManager.SetHeroStats -= _screenManager.HeroSelectionScreen.SetStats;
       
       _heroManager.GetPlayerMoney -= _playerManager.GetMoney;
       
       _heroManager.ChooseHero -= _playerManager.SetHero;
       _heroManager.ChooseHero -= _screenManager.LobbyScreen.SetStats;
       
       _heroManager.PurchaseHero -= _playerManager.BuyHero;
   }
}
