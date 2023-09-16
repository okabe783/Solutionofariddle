using UnityEngine;
using DG.Tweening;
using System.Collections;

public class SubmitPosition : MonoBehaviour
{
    //選択されたカードを管理する
    Card submitCard;

    public Card SubmitCard => submitCard;

    //自分の子要素にする・位置を自分の場所にする
    public void Set(Card card)
    {
        submitCard = card;
        card.transform.SetParent(transform);
        card.transform.position = transform.position;
    }
    //手札のカードを消す
    public void DestroyCard()
    {
        Destroy(submitCard.gameObject);
        submitCard = null;
    }
    public void AttackEffect()
    {
        this.transform.DOMoveX(4, 0.25f).SetLoops(2, LoopType.Yoyo);
    }
}