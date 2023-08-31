using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    //カードUI
    //ゲーム内の処理
    [SerializeField] Image icon;
    [SerializeField] Text descriptionText;
    public CardBase Base { get; private set; }

    //UnityActionは関数を登録する
    public UnityAction<Card> OnClickCard;
    public void Set(CardBase cardBase)
    {
        Base = cardBase;
        icon.sprite = cardBase.Icon1;
        descriptionText.text = cardBase.Description;
    }
    public void OnClick()
    {
        OnClickCard?.Invoke(this);
    }
}
