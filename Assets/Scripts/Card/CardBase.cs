using System;
using UnityEngine;

[CreateAssetMenu]
public class CardBase : ScriptableObject
{
    //カードの基礎データ
    [SerializeField] string cardName;
    [SerializeField] CardType cardType;
    [SerializeField] int cardNumber;
    [SerializeField] Sprite Icon;
    [TextArea]
    [SerializeField] string description;
    public string CardName { get => cardName; }
    public CardType CardType { get => cardType; }
    public int CardNumber { get => cardNumber; }
    public Sprite Icon1 { get => Icon; }
    public string Description { get => description; }
}

//ビットフラグで相性を管理する

[Flags]
public enum CardType
{
    None = 0,
    Sword = 1 << 0,   // 1
    Shield = 1 << 1,  // 2
    Spear = 1 << 2,   // 4
    Bow = 1 << 3,     // 8
    Special = 1 << 4, // 16
    Gun = 1 << 5,     // 32
    Fist = 1 << 6,    // 64
    Heal = 1 << 7,     // 128
    Shuriken = 1 << 8,   //256
    Axe = 1 << 9, //512
    Staff = 1 << 10, //1024
    Machinegun = 1 << 11, //2048
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