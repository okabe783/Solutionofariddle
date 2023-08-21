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

public  enum CardType
{
    Sword,
    Shield,
    Spear,
    Bow,
    Special,
    Gun,
    Fist,
    Heal,
    Red,
    Blue,
    Green,
    Yellow,
}