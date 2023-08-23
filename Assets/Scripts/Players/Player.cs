using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerHand _hand;
    [SerializeField] SubmitPosition _submitposition;
    bool _isSubmitted;
    public UnityAction OnSubmitAction;
    public PlayerHand Hand { get => _hand; }

    public void SetCardToHand(Card card) //カードをこのタイミングで認識する
    {
        
        //カードが配られた時に自分の関数を登録しておく
        _hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    void SelectedCard(Card card)
    {
        if (_isSubmitted == true)
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
        _isSubmitted = true;
        //Managerに通知
        OnSubmitAction?.Invoke();
    }
}
