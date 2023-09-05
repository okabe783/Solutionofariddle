using System;
using UnityEngine;
public class CardBase : ScriptableObject
{
    //カードの基礎データ
    [SerializeField] string _cardName;
    [SerializeField] int _cardNumber;
    [SerializeField] Sprite _icon;
    [TextArea]
    [SerializeField] string _description;
    [SerializeField] PlayerType _playerType;
    [SerializeField] EnemyType _enemyType;
    public string CardName { get => _cardName; }
    public int CardNumber { get => _cardNumber; }
    public Sprite Icon1 { get => _icon; }
    public string Description { get => _description; }
    public PlayerType PlayerType { get => _playerType; }

    public EnemyType EnemyType { get => _enemyType; }
}

//ビットフラグで相性を管理する

[Flags]
public enum PlayerType
{
    None = 0,
    Kizaki = 1 << 0,   // 1
    Hasiwaka = 1 << 1,  // 2
    Itadaki = 1 << 2,   // 4
    Nanase = 1 << 3,     // 8
    Yukime = 1 << 4, // 16
    Hyakuti = 1 << 5,     // 32
    Kimata = 1 << 6,    // 64
    Yuzuki = 1 << 7,     // 128
    Inukai = 1 << 8,   //256
    Tennoji = 1 << 9, //512
    Risia = 1 << 10, //1024
    Kurofusi = 1 << 11, //2048
    Kongoji = 1 << 12, //4096
    Yorugami = 1 << 13, //8192
}

[Flags]
public enum EnemyType
{
    None = 0,
    Red = 1 << 0,    // 1
    Blue = 1 << 1,   // 2
    Green = 1 << 2,  // 4
    Yellow = 1 << 3  // 8
}