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

    //entityにカードを追加
    //クリックされたときに選択されたカードを移動
    public void SetCardToHand(Card card) 
    {
        //カードが配られた時に自分の関数を登録しておく
        Hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    //手札のカードを選択されたときに提出位置にセット
    void SelectedCard(Card card)
    {
        if (IsSubmitted)
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

    //ボタンが押されたとき提出されたことをgamemanagerに通知
    public void OnSubmitButton()
    {
        if (_submitposition.SubmitCard)
        {
            //カードの決定、変更不可
            IsSubmitted = true;
            //Managerに通知
            OnSubmitAction?.Invoke();
        }
    }
    //enemyがランダムにカードを提出する
    public void RandomSubmit()
    {
        //手札からランダムにカードを抜き取る←ここを変更
        Card card = _hand.RandomRemove();
        //提出用にセット
        _submitposition.Set(card);
        //ゲームマネージャに通知する
        IsSubmitted = true;
        OnSubmitAction?.Invoke();
        _hand.ResetPosition();

    }

    //提出したカードを削除
    public void TurnChange()
    {
        IsSubmitted = false;
        _submitposition.DestroyCard();
    }
}