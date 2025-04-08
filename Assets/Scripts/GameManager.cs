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
       _playerManager.OnCoinsAdd += _screenManager.LuckySpinScreenView.SetCoinsAdditive;
       _playerManager.OnGemsChanged += _screenManager.SetGems;
       _playerManager.OnGemsAdd += _screenManager.LuckySpinScreenView.SetGemsAdditive;

       _heroManager.SetHeroStats += _screenManager.HeroSelectionScreen.SetStats;
       
       _heroManager.GetPlayerMoney += _playerManager.GetMoney;
       
       _heroManager.ChooseHero += _playerManager.SetHero;
       _heroManager.ChooseHero += _screenManager.LobbyScreen.SetStats;

       _heroManager.PurchaseHero += _playerManager.BuyHero;
   }

   private void OnDestroy()
   {
       _playerManager.OnCoinsChanged -= _screenManager.SetCoins;
       _playerManager.OnCoinsAdd -= _screenManager.LuckySpinScreenView.SetCoinsAdditive;
       _playerManager.OnGemsChanged -= _screenManager.SetGems;
       _playerManager.OnGemsAdd -= _screenManager.LuckySpinScreenView.SetGemsAdditive;
       
       _heroManager.SetHeroStats -= _screenManager.HeroSelectionScreen.SetStats;
       
       _heroManager.GetPlayerMoney -= _playerManager.GetMoney;
       
       _heroManager.ChooseHero -= _playerManager.SetHero;
       _heroManager.ChooseHero -= _screenManager.LobbyScreen.SetStats;
       
       _heroManager.PurchaseHero -= _playerManager.BuyHero;
   }
}
