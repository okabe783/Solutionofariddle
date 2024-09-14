using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    //カードUI
    //ゲーム内の処理
    [SerializeField] private Image icon;
    [SerializeField] private Text descriptionText;
    public CardBase Base { get; private set; }

    //UnityActionは関数を登録する
    //カードがクリックされたときに特定のアクションを実行する
    public UnityAction<Card> OnClickCard;
    
    //カードの外観を設定
    public void CardSet(CardBase cardBase)
    {
        Base = cardBase;
        icon.sprite = cardBase.Icon1;
        descriptionText.text = cardBase.Description;
    }
    //カードがクリックされたとき
    public void OnClick()
    {
        OnClickCard?.Invoke(this);　//カードがクリックされたことを通知
    }
}