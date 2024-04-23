using UnityEngine;
using Extensions;
using Screen = Extensions.Screen;

public class ScreenManager : MonoBehaviour
{
    public HeroSelectionScreen HeroSelectionScreen => _heroSelectionScreen;
    public LobbyScreen LobbyScreen => _lobbyScreen;

    [SerializeField] private HeroSelectionScreen _heroSelectionScreen;
    [SerializeField] private LobbyScreen _lobbyScreen;

    public void SetCoins(int coins)
    {
        _lobbyScreen.SetCoins(coins);
        _heroSelectionScreen.SetCoins(coins);
    }

    public void SetDiamonds(int diamonds)
    {
        _lobbyScreen.SetDiamonds(diamonds);
        _heroSelectionScreen.SetDiamonds(diamonds);
    }
}
