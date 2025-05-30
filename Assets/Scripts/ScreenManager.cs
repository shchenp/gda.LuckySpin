using UnityEngine;
using Extensions;
using LuckySpin;
using UnityEngine.Serialization;
using Screen = Extensions.Screen;

public class ScreenManager : MonoBehaviour
{
    public HeroSelectionScreen HeroSelectionScreen => _heroSelectionScreen;
    public LobbyScreen LobbyScreen => _lobbyScreen;
    public LuckySpinScreenView LuckySpinScreenView => _luckySpinScreenView;

    [SerializeField] private HeroSelectionScreen _heroSelectionScreen;
    [SerializeField] private LobbyScreen _lobbyScreen;
    [SerializeField] private LuckySpinScreenView _luckySpinScreenView;

    public void SetCoins(int coins)
    {
        _lobbyScreen.SetCoins(coins);
        _heroSelectionScreen.SetCoins(coins);
        _luckySpinScreenView.SetCoins(coins);
    }

    public void SetGems(int diamonds)
    {
        _lobbyScreen.SetGems(diamonds);
        _heroSelectionScreen.SetGems(diamonds);
        _luckySpinScreenView.SetGems(diamonds);
    }
}