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
    Yanagi = 1 << 14,
    Kouga = 1 << 15,
    Genma = 1 << 16,
    Yaiba　= 1 << 17,
    Manami = 1 << 18,
    Otogi = 1 << 19,
    Paraberamu = 1 << 20,
    Mabosi = 1 << 21,
    Sima = 1 << 22,
    Yuraki = 1 << 23,
    //ここ
    Haisiki = 1 << 24,
    Ryutan = 1 << 25,
    Sekidou　= 1 << 26,
    Mitori = 1 << 27,
    Siratori = 1 <<28,
    Gotouda = 1 << 29,
    Yokosima = 1 << 30,
    Sabitani = 1 << 31,
    Cuga = 1 << 32,
    Nano = 1 << 33,
    Himeno = 1 << 34,
    Miki = 1 << 35,
    Momoti = 1 << 36,
    Akamatu = 1 << 37,
    Otuki = 1 <<38,
    Kondou = 1 << 39,
    Jyack = 1 << 40,
    Jyozetu = 1 << 41,
    Tuzimura = 1 << 42,
}

[Flags]
public enum EnemyType
{
    None = 0,
    Red = 1 << 0,    // 1
    Blue = 1 << 1,   // 2
    Green = 1 << 2,  // 4
    Yellow = 1 << 3,  // 8
    Gold = 1 << 4, //16
    Purple = 1 << 5, //32
    White = 1 << 6, //64
}