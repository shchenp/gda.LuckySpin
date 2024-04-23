using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroStats : MonoBehaviour
{
    public string PlayerName => _playerName;
    public string HeroName => _heroName;

    public int Level => _level;
    public int Experience => _experience;
    public Sprite Class => _class;

    public bool IsAvailable => _isAvailable;
    public int Cost => _cost;

    public int Health => _health;
    public int Attack => _attack;
    public int Defence => _defence;
    public int Speed => _speed;
    
    [SerializeField] private string _playerName;
    [SerializeField] private string _heroName;

    [SerializeField] private int _level;
    [SerializeField] private int _experience;
    [SerializeField] private Sprite _class;

    [SerializeField] private bool _isAvailable;
    [SerializeField] private int _cost;

    [SerializeField] private int _health;
    [SerializeField] private int _attack;
    [SerializeField] private int _defence;
    [SerializeField] private int _speed;

    public void SetAvailable()
    {
        _isAvailable = true;
    }
}
