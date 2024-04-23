using UnityEngine;
using Extensions;
using Screen = Extensions.Screen;

public class ScreenManager : MonoBehaviour
{
    public HeroSelectionScreen HeroSelectionScreen => _heroSelectionScreen;
    public LobbyScreen LobbyScreen => _lobbyScreen;
    public LuckySpinScreen LuckySpinScreen => _luckySpinScreen;

    [SerializeField] private HeroSelectionScreen _heroSelectionScreen;
    [SerializeField] private LobbyScreen _lobbyScreen;
    [SerializeField] private LuckySpinScreen _luckySpinScreen;

    public void SetCoins(int coins)
    {
        _lobbyScreen.SetCoins(coins);
        _heroSelectionScreen.SetCoins(coins);
        _luckySpinScreen.SetCoins(coins);
    }

    public void SetDiamonds(int diamonds)
    {
        _lobbyScreen.SetDiamonds(diamonds);
        _heroSelectionScreen.SetDiamonds(diamonds);
        _luckySpinScreen.SetDiamonds(diamonds);
    }
}
