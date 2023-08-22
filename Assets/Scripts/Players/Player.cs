using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerHand _hand;

    public PlayerHand Hand { get => _hand; }

    public void SetCardToHand(Card card) //カードをこのタイミングで認識する
    {
        //カードが配られた時に自分の関数を登録しておく
        _hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    void SelectedCard(Card card)
    {
        Debug.Log(card.Base.CardNumber);
    }
}
