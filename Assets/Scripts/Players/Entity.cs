using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Entity : MonoBehaviour
{
    [SerializeField] PlayerHand _hand;
    [SerializeField] SubmitPosition _submitposition;
    public bool IsSubmitted { get; private set; }
    public UnityAction OnSubmitAction;
    public PlayerHand Hand { get => _hand; }
    public Card SubmitCard { get => _submitposition.SubmitCard; }
    public int Life { get; set; }
    public void SetCardToHand(Card card) //カードをこのタイミングで認識する
    {
        //カードが配られた時に自分の関数を登録しておく
        _hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    void SelectedCard(Card card)
    {
        if (IsSubmitted == true)
        {
            return;
        }
        //すでにセットしていれば、手札に戻す
        if (_submitposition.SubmitCard)
        {
            _hand.Add(_submitposition.SubmitCard);
        }
        _hand.Remove(card);
        _submitposition.Set(card);
        _hand.ResetPosition();
    }
    public void OnSubmitButton()
    {
        //カードの決定、変更不可
        IsSubmitted = true;
        //Managerに通知
        OnSubmitAction?.Invoke();
    }
    public void SetUpNextTurn()
    {
        IsSubmitted = false;
        _submitposition.DestroyCard();
    }
}
